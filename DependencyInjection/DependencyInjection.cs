using System;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    public class DependencyInjection
    {
        public static void Test()
        {

           
        }
    }

    public class UI
    {
        private IBiz _biz;
        public UI(IBiz bz)
        {
            _biz = bz;
        }
        public void CallBizAndSave(string name, string pwd)
        {
            //var biz = new Biz();
            _biz.CallDBandPersist(name, pwd);
        }
    }

    public class Biz : IBiz
    {
        private IDB _db;
        public Biz(IDB db)
        {
            _db = db;
        }
        public void CallDBandPersist(string name, string pwd)
        {

            _db.PersistToDB(name, pwd);

        }

    }

    public class DB : IDB
    {
        public void PersistToDB(string name, string pwd)
        {
            // save and chill
        }
    }

    public interface IBiz
    {
        void CallDBandPersist(string name, string pwd);
    }

    public interface IDB
    {
        void PersistToDB(string name, string pwd);
    }
}

