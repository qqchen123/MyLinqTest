using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NhibernateTest.Model;

namespace NhibernateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                using (var tx= session.BeginTransaction())
                {
                    Owners owners = new Owners() { Id = 11, Name = "qweqwe", AddressId = 1, HouseNumber = "1-1" };
                    session.Save(owners);
                    tx.Commit();
                }
            }
        }
            //    static void Main(string[] args)
            //    {
            //        var configuration = new Configuration();
            //        configuration.Configure();
            //        configuration.AddAssembly("NhibernateTest");

            //        ISessionFactory sessionFactory = null;
            //        ISession session = null;
            //        try
            //        {
            //            //Console.WriteLine("123123123");
            //            sessionFactory = configuration.BuildSessionFactory();
            //            session = sessionFactory.OpenSession();
            //            using (var tx = session.BeginTransaction())
            //            {
            //                Owners owners = new Owners() { Id = 11, Name = "qweqwe", AddressId = 1, HouseNumber = "1-1" };
            //                session.Save(owners);
            //                tx.Commit();
            //            }

            //            //Owners owners = session.Get<Owners>(2);
            //            //Console.WriteLine(owners.Id+"---"+owners.Name);
            //        }
            //        catch (Exception e)
            //        {
            //            Console.WriteLine(e);
            //        }
            //        finally {
            //            if (session != null)
            //            {
            //                session.Close();
            //            }
            //            if (sessionFactory != null)
            //            {
            //                sessionFactory.Close();
            //            }
            //        }

            //        Console.ReadKey();
            //    }
            //}
        }
