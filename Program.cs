using System;
using System.Collections.Generic;
using System.Linq;//اضافه کنیم

//دستورات لینک خیلی زیادن مقداریش رو در اینجا میگیم
//متد ها و اکستنشن متد های زیادی دارد لینک

//کد های لامدای هر لینک را زیر ان لینک مینویسم

namespace ConsoleApp1_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //linq
            //از هر بانکی مثل جیمیل تلگرام و هر بانک دیگری پرس و جو میکنه و کوئری میگیرد و فقط میگیرد چیزی اضافه نمیکند چیزی تعغیر نمیدهد و فقط میگیرد
            //تعغیرات بر عهده پروایدر در انتیتی فریم ورک است

            //select * from SqlDataTableName as P // دستور ای دی او دات نت هست که میگه همه را از اسم تیبل دیتا بیسمان سلکت کن و الیاز -یا همان کلمه از یا همان ای اس- پی یعنی نتیجه را در پی بریز . الیاز پی یعنی نتیجه سلکت شده را در جدولی مانند جدولی که نام بردیم بریز و اسم جدول جدید را پی بگذار 
            //From P in DataBaseTableName Select P // دستور لینک یعنی پی را از مجموعه بانک ما که میتونه تیبل باشه میتونه تلگرام باشه بگیر و بده پی را  

            int[] Numbers = { 1, 3, 5, 7, 9, 10, 20, 3, 19, 18, 17, 16, 15, 11, 25, 28, 28, 30, 40, 100, 99, 70, 80, 90, 60, 50, 50 };

            // ارایه اینت نامبرز یک مجموعه است 

            //foreach (int Print in Numbers)
            //{
            //    Console.WriteLine(Print);
            //}

            //Console.WriteLine("-------------------------------------------------------------------");

            //int[] Result1 = (from n in Numbers select n).ToArray();//خب الان لینک کوئری میزنه و نتایج رو میگیره کجا ذخیره کنه؟ توی هم نوع خودش اینجا چون کالکشن ما ارایه اینت هست ما هم مجبور هستیم در ارایه اینت ذخیرش کنیم. دستورات لینک باید در پرانتز باز و بسته شده نوشته شوند. کوئری رو مینویسیم از ان از نامبر ان را انتخاب کن پرانتز بسته و حالا باید تبدیل به ارایه کنیمش پس متد دات تو اری را ادامش مینویسیم و سمیکالن  

            //int[] Lambda1 = Numbers.ToArray();//کد لامدا لینک بالا. اول اسم مجموعه سپس دات تو اری که اکستنشن متد هستش
            //int[] Lambda1 = Numbers;

            //var Lambda2 = Numbers.ToArray();//کد لامدا لینک بالا. اول اسم مجموعه سپس دات تو اری که اکستنشن متد هستش

            //foreach (int Print in Result1)
            //{
            //    Console.WriteLine(Print);
            //}

            //Console.WriteLine("-------------------------------------------------------------------");

            //int[] Result2 = (from n in Numbers
            //                 orderby n descending
            //                 select n).ToArray();//از ان از نامبرز نزولی مرتب کن ان را و ان را انتخاب کن
            //                                     //اگر ننویسسیم به صورت پیش فرز صعودی مرتب میکند
            //                                     //همیشه سلکت ان اخر می اید
            //                                     //orderby in linq //سرهم نوشته میشود
            //                                     //ولی//order by in sql


            //var Lambda3 = Numbers.OrderByDescending(n => n).ToArray();//کد لامدا لینک بالا. همیشه اول اسم مجموعه میاد . نامبرز دات اوردربای دیسندینگ که نزولی مرتب میکند از بزرگ به کوچک. اوردر بای هم به صورت دیفالت از کوچک به بزرگ صعودی مرتب میکند . اردربای یک اکستنشن متد هست و در پرانتزش باید یک لامدا اکسپرشن بگیرد. در پرانتز سمت چپ علامت لامبدا اکسپرشن ورودی ما هست که اِن از نمایندگی نامبرز هست مانند فرام ان این نامبرز و علامتش یعنی ان را درون لامبدا وارد کنیم به بدنه لامبدا وارد کنیم تا کاری انجام شود  و این علامت دو کار انجام میدهد که بعد ها مطالعه شود 


            //foreach (int Print in Result2)
            //{
            //    Console.WriteLine(Print);
            //}

            //Console.WriteLine("-------------------------------------------------------------------");

            //int[] Result3 = (from n in Numbers
            //                 orderby n
            //                 select n).ToArray();


            //var Lambda4 = Numbers.OrderBy(n => n).ToArray();//کد لامدای لینک بالا . اول اسم مجموعه بعد دستور اوردربای که صعودی مرتب میکند از کوچک به بزرگ و در پرانتزش لامدا اکپرشن را مینویسیم که ان را ورودی به بدنه لامدا میکنیم و بعد هم دات تو اری .


            //foreach (int Print in Result3)
            //{
            //    Console.WriteLine(Print);
            //}

            //Console.WriteLine("-------------------------------------------------------------------");

            //int[] Result4 = (from n in Numbers
            //                 orderby n ascending
            //                 select n).ToArray();

            //foreach (int Print in Result4)
            //{
            //    Console.WriteLine(Print);
            //}

            //Console.WriteLine("-------------------------------------------------------------------");

            //int[] Result5 = (from n in Numbers
            //                 where n > 11 && n < 90
            //                 select n).ToArray();           

            //foreach (int Print in Result5)
            //{
            //    Console.WriteLine(Print);
            //}

            //Console.WriteLine("-------------------------------------------------------------------");

            //int[] Result6 = (from n in Numbers
            //                 where n > 11 && n < 90
            //                 orderby n descending
            //                 select n).ToArray();

            //int[] Result6 = (from n in Numbers
            //                 orderby n descending
            //                 where n > 11 && n < 90
            //                 select n).ToArray();

            //var Lambda5 = Numbers.Where(n => n > 11 && n < 90).OrderByDescending(n => n).ToArray();
            ////اول که نامبرز. بعد شرط هست و باید درون پرانتزش اکسپرشن بزنیم خب اِن به نمایندگی از مجموعه
            ////وارد پرانتز میشود و بعد علامت کلیدی لامدا اکسپرشن که <= هست را میزاریم تا وارد اکسپرشن شود و شرط را مینویسم
            ////و بعد اوردر میدهیم که نزولی باشد و در پرانتز ان هم اکسپرشن میدهیم هر پرانتز قلمرو خودش را دارد
            //// و اِن ها با هم متفاوت هستند یعنی اگر شما اِم هم بزارید پرانتز بعدی را اتفاقی نمی افتد
            //// چون شرط را اجرا میکند روی اِن که نماینده نامبرزی هست که ابتدا نام بردیم ازش
            //// و بعد نتایج ان را که اِن نامیدیم را که میتوانیم هرچیزی بنامیمش را مرتب میکنیم
            ////ولی در لینک بالا نمیتوانیم اِن را برای مثال از وسط ماجرا بعد انجام شدن شرط اِم بنامیم
            ////در لینک میگه اِن از نامبرز .بعد شرط را روی اِن انجام میدهد و دوباره اِن را میریزد توی اِن 
            ////ولی در لامدا میگوید نامبرز را میگیریم اکسپرشن میکنیمش و در بدنه پرانتزش آن را 
            ////هرچه بخواهیم مینامیم
            ////و بعد در ادامه که باقی لامدا اکسپرشن ها اضافه میشوند میگوید نتیجه اکسپرشن قبلی را میگیریم
            ////و هرچه بخواهیم مینامیمش


            //foreach (int Print in Result6)
            //{
            //    Console.WriteLine(Print);
            //}

            //Console.WriteLine("-------------------------------------------------------------------");

            //حالا میخوایم یکی را که شرط دلخواهمان را دارد را انتخاب کنیم

            //int[] Result7 = (from n in Numbers where n == 3 select n).ToArray();

            //foreach (int Print in Result7)
            //{
            //    Console.WriteLine(Print);
            //}

            //Console.WriteLine("-------------------------------------------------------------------");

            ////خب حالا اگر فقط یکی را بخواهیم یعنی فقط یک دونه از ان را چه

            //int Result8 = (from n in Numbers where n == 3 select n).First();// دات فیرست .این دستور یعنی اولین ایتمی که شرط را داشت را بیاور . و از انجایی که فقط یک دونه میخواییم نیازی به ارایه نداریم 

            //int Result8 = (from n in Numbers select n).First();//اگر شرط نداشته باشد میرود و اولی را میگیرد و میاورد

            //int Result8 = (from n in Numbers
            //               orderby n descending
            //               select n).First()

            //var Lambda6 = Numbers.First();//میره اولی رو میاره
            //var Lambda7 = Numbers.First(n => n == 3);//میره اولین 3 رو میاره و ما از دات وِر استفاده نکردیم


            //Console.WriteLine(Result8);

            //int Result10 = (from n in Numbers
            //                where n > 40
            //                select n).First();

            //Console.WriteLine(Result10);

            //Console.WriteLine("-------------------------------------------------------------------");

            ////اگر گشت و ایتمی نبود که شرط را برقرار کند چه

            //int[] Result9 = (from n in Numbers
            //                 where n > 100
            //                 select n).ToArray();

            //foreach (int Print in Result9)
            //{
            //    Console.WriteLine(Print);
            //}

            ////ارایه را خالی برمیگرداند.خالی خالی . خالیه واقعی

            //Console.WriteLine("-------------------------------------------------------------------");

            ////اگر ارایه نباشد چه

            //int Result11 = (from n in Numbers
            //                where n > 100
            //                select n).First();

            //Console.WriteLine(Result11);

            ////int Result12 = (from n in Numbers
            ////                where n ==2
            ////                select n).First();


            ////var Lambda12 = Numbers.First(n => n == 2);//ارور میدهد چون شرط حاصل وجود ندارد و ایتم مورد نظر موجود نیست


            ////Console.WriteLine(Result12);

            ////دو خط بالا ارور میدهند مگر به شکل زیر

            //int Result13 = (from n in Numbers
            //                where n > 100
            //                select n).FirstOrDefault();//فرست اور دیفالت قسمت فرستش که همون کار فرست رو انجام میده قسمت دیفالتش برای اینکه ارور را از بین ببره میاد مقدار دیفالتِ اینت را که صفر هست را جای نتیجه کوئری قرار میدهد 

            //Console.WriteLine(Result13);

            //int Result14 = (from n in Numbers
            //                where n == 2
            //                select n).FirstOrDefault();


            //var Lambda8 = Numbers.FirstOrDefault();//اولی رو میاره
            //var Lambda9 = Numbers.FirstOrDefault(n => n == 2);//دیفالت که صفره میده

            //Console.WriteLine(Lambda8);

            //Console.WriteLine(Result14);

            //Console.WriteLine("-------------------------------------------------------------------");

            //int Result15 = (from n in Numbers where n == 3 select n).Single();//اگر شرط نداشته باشه صددرصد ارور


            ////var Lambda10 = Numbers.Single();//حتما باید شرط داشته باشه
            //var Lambda11 = Numbers.Single(n => n == 100);//صد را میاورد
            //     //و باید قوانین سینگل را رعایت کنیم دیگر اینکه اگر نباشد ایتم مورد نظر ارور برمیگرداند
            //     //شرط داشته باشد و بیشتر از یکی نباشد


            //Console.WriteLine(Result15);

            //سینگل دقیقا کار فرست را انجام میدهد با این تفاوت که فقط و فقط میتواند یک ایتم را بگیرد و اگر از ان ایتم بیشتر از یک عدد باشد ارور برمیگرداند حتی اگر سینگل اور دیفالت باشد. دومین تفاوت درر این است که فرست تمام لیست را جستجو نمیکند وقتی پیداش کند دیگر ادامه نمیدهد و نتیجه را می اورد ولی سینگل تمام لیست را جست جو میکند تا اخر که مطمئن شود 

            //int Result16 = (from n in Numbers
            //                where n > 40
            //                select n).SingleOrDefault();//بازم ارور میده چون چنیدین ایتم داریم

            //Console.WriteLine(Result16);

            //int Result17 = (from n in Numbers where n == 5 select n).Single();//اینجا میگرده دنبالش و برمیگردونه همین یه دونه رو . سینگل مال وقتی هست که ما میخوایم چک کنیم فقط یک دونه داریم از یک چیزی

            //Console.WriteLine(Result17);

            //int Result18 = (from n in Numbers
            //                where n > 50 && n < 70
            //                select n).SingleOrDefault();

            //Console.WriteLine(Result18);

            //int Result19 = (from n in Numbers
            //                where n > 100
            //                select n).Single();//ارور میده چون ندارد این ایتم را و باید سینگل اور دیفالت باشد

            //Console.WriteLine(Result19);

            //int Result20 = (from n in Numbers
            //                where n > 100
            //                select n).SingleOrDefault();// این هم مثل فرست اور دیفالت اگر نبود مقدار دیفالت را برمیگرداند


            ////var Lambda13 = Numbers.SingleOrDefault();//چون شرط ندارد ارور میدهد
            //var Lambda14 = Numbers.SingleOrDefault(n => n > 50 && n < 70);//شرط که شصت هست را نشان میدهد
            //var Lambda15 = Numbers.SingleOrDefault(n => n > 100);//چون موجود نیست دیفالت را که صفر هست برمیگرداند


            //Console.WriteLine(Result20);

            //int Result21 = (from n in Numbers
            //                where n == 2
            //                select n).SingleOrDefault();

            //Console.WriteLine(Result21);

            //var findEx = (from n in Numbers
            //              where n == 3
            //              select n).Find();

            //Console.WriteLine("-------------------------------------------------------------------");

            ////var
            ////متغیر . وریبیل
            ////به این صورت هست که نوع مشخصی ندارد. و اولین مقداری که واردش شود همان نوعی میشود مثلا

            //var I1 = 123;//ای یک اینت شد
            //var I2 = "123";//آی دو استرینگ شد
            //var I3 = DateTime.Now;//دیت تایم شد
            //var I4 = 'I';//کر شد .کرکتر شد
            //var I5 = true;//بولین شد

            ////I1 = "123";// ارور میده میگه شما نمیتونید استرینگ توی اینت بریزید

            //-------------------------------------------------------------------------------------------

            ////خب حالا مثلا میخوایم کوئری بزنیم که بره چک کنه ببینه هست یا نه . نره برش داره بیاره برامون فقط چک کنه ببینه هست یا نه تا منابع کمتری مصرف شه

            //bool Result22 = (from n in Numbers
            //                 where n == 2
            //                 select n).Any();//دات انی چک میکند که هیچ نتیجه ای دارد یا نه

            //Console.WriteLine(Result22);

            //bool Result23 = (from n in Numbers
            //                 where n == 50
            //                 select n).Any();//دوتا پنجاه داریم

            //if (Result23)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //bool Result24 = (from n in Numbers
            //                 where n > 50
            //                 select n).Any();//چندین نتیجه مختلف

            //Console.WriteLine(Result24);

            //bool Result25 = (from n in Numbers
            //                 where n > 100
            //                 select n).Any();//رنجی از اعداد ناموجود

            //Console.WriteLine(Result25);


            //var Lambda16 = Numbers.Any(n => n == 2);//همه چی مشابه دات انی لینکه
            //Console.WriteLine(Lambda16);

            ////------------------------------------------------------------------------------

            //تعداد ایتم های کالکشنمان

            //int Count = (from n in Numbers
            //             select n).Count();//چون شمارش هست و یک عدد برمیگردونه یک متغیر اینت


            //var Lambda17 = Numbers.Count();//شبیه کانت لینکه .این یکی همه را میشمارد
            //var Lambda18 = Numbers.Count(n => n == 50);//این یکی یک نوع خاص را تکراری ها را هم همینطور
            //var Lambda19 = Numbers.Count(n => n % 2 == 0);//زوج ها
            //var Lambda20 = Numbers.Count(n => n % 2 == 1);//فردها
            //var Lambda21 = Numbers.Count(n => n > 100);//ناموجود ها که میشوند صفر تا
            //var Lambda22 = Numbers.Count(n => n >= 28 && n <= 50);//بین یک بازه بزرگتر مساوی کوچکتر مساوی با اعداد تکراری

            //Console.WriteLine(Lambda21);

            //Console.WriteLine(Count);

            //int Count2 = (from n in Numbers
            //              where n > 40 && n <= 100
            //              select n).Count();//شمارش تعداد با شرط

            //Console.WriteLine(Count2);

            //int[] Result26 = (from n in Numbers
            //                  where n % 2 == 0
            //                  orderby n ascending
            //                  select n).ToArray();//چاپ اعداد زوج مرتب شده صعودی


            //var Lambda23 = Numbers.OrderBy(n => n % 2 == 0).ToArray();//این یکی همه را چاپ میکند حتی اوردر بای هم نمیکند ان را 
            //var Lambda24 = Numbers.Where(n => n % 2 == 0).OrderBy(n => n).ToArray();// مثل لینک بالا

            //foreach (int Print in Lambda23)
            //{
            //    Console.WriteLine(Print);
            //}

            //foreach (int Print in Lambda24)
            //{
            //    Console.WriteLine(Print);
            //}

            //foreach (int Print in Result26)
            //{
            //    Console.WriteLine(Print);
            //}

            //int Count3 = (from n in Numbers
            //              where n % 2 == 0
            //              select n).Count();//شمارش اعدا زوج حتی تکراری

            //Console.WriteLine(Count3);

            //int[] Result27 = (from n in Numbers
            //                  where n % 2 == 1
            //                  orderby n descending
            //                  select n).ToArray();//چاپ اعداد فرد مرتب شده نزولی

            //foreach (int Print in Result27)
            //{
            //    Console.WriteLine(Print);
            //}

            //int Count4 = (from n in Numbers
            //              where n % 2 == 1
            //              select n).Count();// شمارش اعداد فرد حتی تکراری

            //Console.WriteLine(Count4);

            //int Max = (from n in Numbers
            //           select n).Max();//بزرگترین عدد 

            //Console.WriteLine(Max);

            //int Min = (from n in Numbers
            //           select n).Min();//کوچکترین عدد 

            //Console.WriteLine(Min);

            //int EvenMax = (from n in Numbers
            //               where n % 2 == 0
            //               select n).Max();//بزرگترین عدد زوج

            //Console.WriteLine(EvenMax);

            //int OddMax = (from n in Numbers
            //              where n % 2 == 1
            //              select n).Max();//بزرگترین عدد فرد

            //Console.WriteLine(OddMax);

            //int EvenMin = (from n in Numbers
            //               where n % 2 == 0
            //               select n).Min();//کوچکترین عدد زوج

            //Console.WriteLine(EvenMin);

            //int OddMin = (from n in Numbers
            //              where n % 2 == 1
            //              select n).Min();//کوچکترین عدد فرد


            //var Lambda25 = Numbers.Min();//کوچکترین را میاورد.مانند لینک کار میکنند
            //var Lambda26 = Numbers.Max();//بزگترین
            //var Lambda27 = Numbers.Min(n => n % 2 == 0);//بولین برمیگرداند نمیدانم چرا
            //var Lambda28 = Numbers.Where(n => n % 2 == 0).Min(n => n);//کوچکترین زوج.میتواند پرانتز مین خالی هم باشد
            //var Lambda29 = Numbers.Where(n => n % 2 == 0).Max();//بزرگترین زوج.میتواند پرانتز مکس پر هم باشد
            //var Lambda30 = Numbers.Where(n => n % 2 == 1).Min();//کوچکترین فرد.میتواند پرانتز مین پر هم باشد
            //var Lambda31 = Numbers.Where(n => n % 2 == 1).Max(n => n);//بزرگترین فرد.میتواند پرانتز مکس خالی هم باشد


            //Console.WriteLine(OddMin);

            //int Sum = (from n in Numbers
            //           select n).Sum();//جمع تمام اعداد کالکشنمان. و چون جمع نتیجش فقط یک عدد هست درون ارایه نمیرود

            //Console.WriteLine(Sum);

            //int Sum2 = (from n in Numbers
            //           where n > 40
            //           select n).Sum();//جمع تمام اعداد کالکشنمان با وجود شرط

            //Console.WriteLine(Sum2);

            //int EvenSum = (from n in Numbers
            //               where n % 2 == 0
            //               select n).Sum();//جمع اعداد زوج

            //Console.WriteLine(EvenSum);

            //int OddSum = (from n in Numbers
            //               where n % 2 == 1
            //               select n).Sum();//جمع اعداد فرد


            //var Lambda32 = Numbers.Sum();//.مانند لینک.همه جمع هارا اورده به پرانتزش هم دست نزنیم بدون استفاده از ور چون میگه شرط نمیتونی بدی 
            //var Lambda33 = Numbers.Where(n=> n>40).Sum(n=>n);//سام با شرطش و اینکه پرانتزش اینجا هم میتونه خالی باشه
            //var Lambda34 = Numbers.Where(n => n == 50).Sum();//وقتی یک شرط دو نتجه دارد
            //var Lambda35 = Numbers.Where(n => n % 2 == 0).Sum();//زوج ها جمع شن


            //Console.WriteLine(OddSum);

            //-----------------------------------------------------------------------------

            //میخوایم لیست بگیریم لیست برگردونیم


            List<string> Names = new List<string>();

            Console.WriteLine("Enter Numbers of Names");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter {a} Names Then  Press ENTER ");

            for (int i = 1; i <= a; i++)
            {
                Names.Add(Console.ReadLine());
            }

            Console.WriteLine("----------------------------------");

            foreach (string Print in Names)
            {
                Console.WriteLine(Print);
            }

            Console.WriteLine("----------------------------------------");//لیست را ساختیم

            //حالا میخواهیم با لینک کوئری بزنیم که لیست را چاپ کنیم

            //List<string> Result28 = new List<string>();

            //Result28 = (from n in Names
            //            select n).ToList();//دات تو لیست.چون لیست هست کالکشن نیمز ما و باید وارد لیست هم بشه البته میشه توی ارایه هم ریخت ولی خب دلیل نمیشه که انجامش بدیم و کار خوبی باشه. و از اونجایی که نمیشه متغیر لیست رو مثل متغیر ارایه استفاده کرد مجبوریم قبلش لیست را تعریف کنیم و بعد استفاده کنیم در اینجا ریزالت 28  


            //var Lambda36 = Names.ToList();//مانند لینک دیگه.
            //var Lambda37 = Names.ToArray();


            //foreach (string Print in Result28)
            //{
            //    Console.WriteLine(Print);
            //}

            //کار اسان تر این هست که از وَر استفاده کنیم

            //var Result29 = (from n in Names
            //                select n).ToList();

            //foreach (string Print in Result29)//اینجا ما میدونیم که لیست نیمز از استرینگ هست و بعد وارد ور ریزالت 29 شده و اون رو تبدیل به لیست استرینگ کرده برای همین ما اینجا از استرینگ استفاده کردیم ولی وقتی مطمئن نیستیم مثل پایین از وَر استفاده میکنیم 
            //{
            //    Console.WriteLine(Print);
            //}

            //foreach (var Print in Result29)
            //{
            //    Console.WriteLine(Print);
            //}

            //var Result30 = (from n in Names
            //                where n.ToLower().Contains("h")
            //                select n).ToList();//دات تو لور که مشخصه اگه نباشه اونایی که با حرف بزرگ هستن رو حساب نمیکنه. دات کانتینز که توش استرینگ میره ، میگه که حاوی چه چیز هایی باشد مانند علامت درصد در دوطرف در کوئری .در اینجا اچ هرجایی که باشه را برمیگرداند چه اول چه اخر چه وسط 

            //foreach (var Print in Result30)
            //{
            //    Console.WriteLine(Print);
            //}

            //var Result31 = (from n in Names
            //                where n.ToLower().Contains("neg")
            //                select n).ToList();

            //foreach (var Print in Result31)
            //{
            //    Console.WriteLine(Print);
            //}

            //var Result32 = (from n in Names
            //                where n.ToLower().StartsWith("ni")
            //                select n).ToList(); //استارتس ویف یعنی باهاش شروع بشه مثل علامت درصد در سمت راست کوئری. متد استارتس ویف برای خود لینک نیست

            //foreach (var Print in Result32)
            //{
            //    Console.WriteLine(Print);
            //}

            //var Result33 = (from n in Names
            //                where n.ToLower().EndsWith("s")
            //                select n).ToList(); //اندزویف یعنی باهاش تموم شود. مثل علامت درصد در سمت چپ کوئری. متد اندزویف هم مثل دات کانتینز و استارتس ویف برای خود لینک نیستند

            //foreach (var Print in Result33)
            //{
            //    Console.WriteLine(Print);
            //}


            //var Lambda38 = Names.Where(n => n.ToLower().Contains("h")).ToList();//مانند لینک.هاوی عبارتی باشد هاوی یک رشته باشد
            //var Lambda39 = Names.Where(n => n.ToLower().Contains("neg")).ToList();//مانند خط بالا
            //var Lambda40 = Names.Where(n => n.ToLower().StartsWith("ni")).ToList();//با رشته ای شروع شود
            //var Lambda41 = Names.Where(n => n.ToLower().EndsWith("s")).ToList();//با رشته ای پایان یابد


        }
    }
}
