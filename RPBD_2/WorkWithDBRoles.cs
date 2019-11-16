using RPBD_2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPBD_2
{
   
    class WorkWithDBRoles
    {
        roles db = new roles();

        // если статуса не нашел вернет ничего
        public string seachStatUser(string log, string pas)
        {
            string stat = "";
            List<USERS> allRole = db.USERS.ToList();
            USERS us = null;
            if ((us = db.USERS.Where(u => u.login == log & u.password == pas).FirstOrDefault()) != null)
                stat = db.STATUSES.Where(s => s.idStat == us.idStat).FirstOrDefault().nameStat;
            return stat;
        }
        
        public int seachStatUser(string stat)
        {
            STATUSES st = null;
            if ((st = db.STATUSES.Where(t => t.nameStat == stat).FirstOrDefault()) != null)
                return st.idStat;
            else return -1;
        }
        // получить всех пользователей
        public List<users> getAllUser()
        {
            List<USERS> allRole = db.USERS.ToList();
            List<users> us = new List<users>();
            foreach (USERS temp in allRole)
            {
                users el = new users();
                el.login = temp.login;
                el.password = temp.password;
                el.FIO = temp.FIO;
                el.nameStat = db.STATUSES.Where(t => t.idStat == temp.idStat).FirstOrDefault().nameStat;
                el.foto = temp.foto;
                us.Add(el);
            }

            return us;
        }
        public List<users> seachUser(string FIO)
        {
            List<users> sUs = new List<users>();
            List<USERS> allUs = db.USERS.ToList();

            foreach (USERS temp in allUs)
            {
                if (temp.FIO == FIO)
                {
                    users retUser = new users();
                    retUser.FIO = temp.FIO;
                    retUser.login = temp.login;
                    retUser.nameStat = db.STATUSES.Where(u => u.idStat == temp.idStat).FirstOrDefault().nameStat;
                    retUser.password = temp.password;
                    retUser.foto = temp.foto;
                    sUs.Add(retUser);
                }
            }
            return sUs;
        }

        // статусы без пациента
        public List<string> allStatusWithoutPatient()
        {
            List<STATUSES> all = db.STATUSES.ToList();
            List<string> str = new List<string>();
            foreach (STATUSES temp in all)
            {
                if (temp.idStat != 3)
                {
                    string el = temp.nameStat;
                    str.Add(el);
                }
            }
            return str;
        }
        public Boolean newUser(string fio, string log, string pass, string stat, string foto)
        {
            Boolean flag = false;
            List<USERS> all = db.USERS.ToList();
            USERS newUser = db.USERS.Where(u => u.login == log).FirstOrDefault();
            if (newUser != null)
                return flag;
            STATUSES st = db.STATUSES.Where(s => s.nameStat == stat).FirstOrDefault();
            newUser = new USERS();
            newUser.FIO = fio;
            newUser.login = log;
            newUser.STATUSES = st;
            newUser.idStat = st.idStat;            newUser.password = pass;
            newUser.foto = foto;
            db.USERS.Add(newUser);
            db.SaveChanges();
            flag = true;
            return flag;
        }
        public Boolean delUser(string log)
        {
            Boolean flag = false;
            USERS us = db.USERS.Where(u => u.login == log).FirstOrDefault();
            if (us == null)
                return flag;
            db.USERS.Remove(us);
            db.SaveChanges();
            flag = true;
            return flag;
        }
        public Boolean UPDUser(string fio, string log, string pass, string stat, string foto)
        {
            Boolean flag = false;
            List<USERS> all = db.USERS.ToList();
            USERS newUser = new USERS();
            USERS newUser1 = db.USERS.Where(u => u.login == log).FirstOrDefault();
            if (newUser1 == null)
                return flag;
            STATUSES st = db.STATUSES.Where(s => s.nameStat == stat).FirstOrDefault();
            newUser.FIO = fio;
            newUser.login = log;
            newUser.STATUSES = st;
            newUser.idStat = st.idStat;
            newUser.foto = foto;

            newUser.password = pass;

            db.USERS.Remove(newUser1);
            db.SaveChanges();
            db.USERS.Add(newUser);
            db.SaveChanges();
            flag = true;
            return flag;
        }

        public users GetUserLog(string log)
        {
            users el = new users();
            USERS temp = db.USERS.Where(t => t.login == log).FirstOrDefault();
            if (temp == null)
                return null;

            el.login = temp.login;
            el.password = temp.password;
            el.FIO = temp.FIO;
            el.nameStat = db.STATUSES.Where(t => t.idStat == temp.idStat).FirstOrDefault().nameStat;
            el.foto = temp.foto;

            return el;
        }
    }
}
