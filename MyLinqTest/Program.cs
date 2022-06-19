using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinqTest
{
    class Program
    {
        static void Main(string[] args) {
            Entities en = new Entities();
            //TDMS_PROJECT_INFO objPro = en.TDMS_PROJECT_INFO.FirstOrDefault(s=>s.PRO_ID==4);
            TDMS_PROJECT_INFO objPro = (from s in en.TDMS_PROJECT_INFO where s.PRO_ID == 5 select s).First<TDMS_PROJECT_INFO>();

            objPro.PROJECT_NAME = "陈恩杰";
            objPro.PMO = "N";
            objPro.SPONSOR = "孙琳";
            int res= en.SaveChanges();
            Console.WriteLine(res);
            Console.ReadLine();
        }

        //static void Main(string[] args)
        //{
        //Entities en = new Entities();
        //TDMS_PROJECT_INFO myPro = en.TDMS_PROJECT_INFO.SingleOrDefault(i=>i.PROJECT_NAME=="1111");
        //if (myPro != null)
        //{
        //    Console.WriteLine(myPro.PROJECT_NAME+" "+ myPro.PRO_ID);
        //}



        //IQueryable<TDMS_PROJECT_INFO> query = en.TDMS_PROJECT_INFO.Where(i => i.PRO_ID < 10);
        //foreach (var item in query)
        //{
        //    Console.WriteLine(item.PRO_ID+"---"+item.PROJECT_NAME+"---"+item.PMO);
        //}
        //Console.ReadLine();
        //}


        //static void Main(string[] args) {
        //    TDMS_PROJECT_INFO pro = new TDMS_PROJECT_INFO() { 
        //        PROJECT_NAME="C#name",
        //        PMO="Y",
        //        SPONSOR="xiaoming",
        //        TECHNOLOGY="myC#",
        //        CUSTOMER="taijidian",
        //        APPLICATION="xinpian",
        //        KEY_WORDS="bandaoti",
        //        FILE_PATH="mypath",
        //    };
        //    Entities en = new Entities();
        //    en.TDMS_PROJECT_INFO.Add(pro);
        //    int res = en.SaveChanges();
        //    Console.WriteLine(res);

        //}



        //static void Main(string[] args)
        //{
        //    var nums1 = Enumerable.Range(1,10);
        //    var nums2 = Enumerable.Repeat("LINQ best!",10);
        //    foreach (var item in nums1)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    foreach (var item in nums2)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadLine();
        //}



        //static void Main(string[] args)
        //{
        //    int[] nums = { 1,2,2,6,5,6,7,8,8};
        //    var list = nums.Distinct();
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);

        //    }
        //    Console.ReadLine();
        //}
        //static void Main(string[] args)
        //{
        //    Student obj1 = new Student()
        //    {
        //        StuId = 1001,
        //        StuName = "学员1"
        //    };

        //    Student obj2 = new Student()
        //    {
        //        StuId = 1009,
        //        StuName = "学员9"
        //    };

        //    Student obj3 = new Student()
        //    {
        //        StuId = 1012,
        //        StuName = "学员12"
        //    };

        //    Student obj4 = new Student()
        //    {
        //        StuId = 1003,
        //        StuName = "学员3"
        //    };

        //    Student obj5 = new Student()
        //    {
        //        StuId = 1019,
        //        StuName = "学员19"
        //    };

        //    Student obj6 = new Student()
        //    {
        //        StuId = 1006,
        //        StuName = "学员6"
        //    };

        //    List<Student> stuList = new List<Student>() { obj1, obj2, obj3, obj4, obj5, obj6 };

        //    var stu1 = from s in stuList
        //               orderby s.StuName, s.Age, s.StuId
        //               select s;
        //    var stu2 = stuList.OrderBy(s => s.StuName).ThenBy(s => s.Age).ThenBy(s => s.StuId).Select(p => p);
        //    foreach (var item in stu1)
        //    {
        //        Console.WriteLine(item.StuName);
        //    }
        //    Console.WriteLine("-------------------");
        //    foreach (var item in stu2)
        //    {
        //        Console.WriteLine(item.StuName);
        //    }
        //    Console.ReadLine();
        //}


        //static void Main(string[] args)
        //{
        //    Student obj1 = new Student()
        //    {
        //        StuId = 1001,
        //        StuName = "学员1"
        //    };

        //    Student obj2 = new Student()
        //    {
        //        StuId = 1009,
        //        StuName = "学员9"
        //    };

        //    Student obj3 = new Student()
        //    {
        //        StuId = 1012,
        //        StuName = "学员12"
        //    };

        //    Student obj4 = new Student()
        //    {
        //        StuId = 1003,
        //        StuName = "学员3"
        //    };

        //    Student obj5 = new Student()
        //    {
        //        StuId = 1019,
        //        StuName = "学员19"
        //    };

        //    Student obj6 = new Student()
        //    {
        //        StuId = 1006,
        //        StuName = "学员6"
        //    };

        //    List<Student> stuList = new List<Student>() { obj1, obj2, obj3,obj4,obj5,obj6 };

        //    var count1 = (from c in stuList
        //                  where c.StuId > 1010
        //                  select c
        //                  ).Count();

        //    var count2 = stuList.Where(i => i.StuId > 1010).Count();

        //    Console.WriteLine("count1={0} count2={1}",count1,count2);
        //    Console.ReadLine();

        //}


        //static void Main(string[] args)
        //{
        //    Student obj1 = new Student()
        //    {
        //        StuId = 1001,
        //        StuName = "学员1"
        //    };

        //    Student obj2 = new Student()
        //    {
        //        StuId = 1009,
        //        StuName = "学员9"
        //    };

        //    Student obj3 = new Student()
        //    {
        //        StuId = 1012,
        //        StuName = "学员12"
        //    };

        //    Student obj4 = new Student()
        //    {
        //        StuId = 1003,
        //        StuName = "学员3"
        //    };

        //    Student obj5 = new Student()
        //    {
        //        StuId = 1019,
        //        StuName = "学员19"
        //    };

        //    Student obj6 = new Student()
        //    {
        //        StuId = 1006,
        //        StuName = "学员6"
        //    };

        //    List<Student> stuList1 = new List<Student>() { obj1,obj2,obj3};
        //    List<Student> stuList2 = new List<Student>() { obj4,obj5,obj6};

        //    var res = from stu1 in stuList1
        //              where stu1.StuId >= 1010
        //              from stu2 in stuList2
        //              where stu2.StuId >= 1010
        //              select new { stu1,stu2};
        //    foreach (var item in res)
        //    {
        //        Console.WriteLine(item.stu1.StuName+" - "+item.stu1.StuId);
        //        Console.WriteLine(item.stu2.StuName+" - "+item.stu2.StuId);
        //    }
        //    Console.ReadLine();
        //}




        //static void Main(string[] args)
        //{
        //    Student obj1 = new Student() {
        //        StuId = 1001, 
        //        StuName = "学员1", 
        //        ScoreList = new List<int>() { 90,78,54}
        //    };
        //    Student obj2 = new Student()
        //    {
        //        StuId = 1002,
        //        StuName = "学员2",
        //        ScoreList = new List<int>() { 95, 88, 90 }
        //    };
        //    Student obj3 = new Student()
        //    {
        //        StuId = 1003,
        //        StuName = "学员3",
        //        ScoreList = new List<int>() { 79, 76, 89 }
        //    };

        //    List<Student> stuList = new List<Student>() { obj1,obj2,obj3};

        //    var res = from stu in stuList
        //              from score in stu.ScoreList
        //              where score >= 90
        //              select stu;
        //    foreach (var item in res)
        //    {
        //        Console.WriteLine(item.StuName);
        //    }
        //    Console.ReadLine();
        //}


        //static void Main(string[] args)
        //{
        //    //int[] nums = { 1,7,3,9,2,8,4,6,5};
        //    //var list = nums.Select(item => item * item);
        //    //var list = nums.Where(i => i % 2 == 0).Select(i=>i).OrderBy(i=>i);
        //    //var list = nums.Where(i => i % 2 == 0).Select(i=>i).OrderByDescending(i=>i);


        //    string[] nums = { "张勇","刘华","陈庚", "孙丽娜", "王凯轮", "刘永", "成龙", "那英", "杜丽" };
        //    //var list = nums.Where(i => i.Length == 2).Select(i => i).OrderByDescending(i => i.Substring(0, 1));
        //    var list = nums.Where(i => i.Length == 2).Select(i => i).GroupBy(i => i.Substring(0, 1));

        //    foreach (var item in list)
        //    {
        //        Console.WriteLine("-----------------");
        //        Console.WriteLine("分组字段:{0}", item.Key);
        //        foreach (var myitem in item)
        //        {
        //            Console.WriteLine(myitem);
        //        }
        //    }
        //    Console.ReadLine();
        //}


    }
}
