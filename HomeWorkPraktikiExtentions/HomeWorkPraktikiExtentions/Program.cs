



using HomeWorkPraktikiExtentions;
using HomeWorkPraktikiExtentions.Helpers.Extentions;
using System.ComponentModel.DataAnnotations;

//int num = 1;

//num.ShowNum();

//int num3 = 110;

//num3.ShowNum();


//int num = 23;

//num.ShowNum(7);



//int number  = 10;

//int number2 = 19;


//int result = number.SumOfNum(number2);

//Console.WriteLine(result);


//string str = "Semed";

//string text = "Huseynov";

//Console.WriteLine(str.ShowText(text));


//string text = "Salam1";

//var result = text.CheckDigitForStr();

//if (result)
//{
//    Console.WriteLine("Have Digit");
//}
//else
//{
//    Console.WriteLine("Havent Digit");
//}


//string email = "Semed1234mail.ru";

//var result = email.CheckEmail();

//Console.WriteLine(result);



//string email = "345676s54567";

//Console.WriteLine(email.CheckStr("@"));
//Console.WriteLine(email.CheckStr(@"\d"));
//Console.WriteLine(email.CheckStr(@"[A-Z]"));
//Console.WriteLine(email.CheckStr(@"[A-Za-z]"));
//Console.WriteLine(email.CheckStr(@"[a-z]"));


//Person person = new("Semed243mailru");


//int number = 3;


//Console.WriteLine(number.FindFactorial());


//Console.WriteLine("Add your email");
//Email: string email = Console.ReadLine();


//if (!email.CheckEmailAndPassword("@"))
//{
//    Console.WriteLine("Email incorrect");
//    goto Email;
//}

//Console.WriteLine("Add your password");
//Password:  string password = Console.ReadLine();



//if (!password.CheckEmailAndPassword(@"\W"))
//{
//    Console.WriteLine("Password incorrect");
//    goto Password;
//}


//Console.WriteLine("Login success");


//double number = 2;

//double pow = 10;



//Console.WriteLine(number.PowOfNumber(pow));


//string str = "4safeg";


//Console.WriteLine(str.IsConvertStringToNumber());



//Car car = new Car();


//car.name = "aeff";

//Console.WriteLine(car.name);


//Car car;

//car.name = "adrefsrf";

//Console.WriteLine(car.name);


//Car car = new Car();


//Console.WriteLine(car.name);



//Car car;

//car.name = " aefaef";

//Console.WriteLine(car.name);


//string name = null;


//if (name is null)
//{
//    Console.WriteLine("Notfound");
//}


//int? age = null;

//Console.WriteLine(age);


//Nullable<int> a = null;


//static void CreateDate(string name , string surname , int? age = null)
//{
//    if( name == null || surname == null || age ==null)
//    {
//        Console.WriteLine("Please fill all inputs");
//    }
//    Console.WriteLine(name +" "+surname+" "+age);
//}

//CreateDate("Tunzale", "Memmedova");


//static void Register(User user)
//{
//    if(user.Weight == null)
//    {
//        Console.WriteLine(user.Weight);
//    }
//}


static void Register(User user)
{
    if(user.Fullname != null&&user.Email!=null&& user.Password != null)
    {
        Console.WriteLine("Register success");
    }
    else
    {
        Console.WriteLine("Register failed");
    }
    
}

Register(new User { Id = 1 , Fullname = "XXX", Email = "Semed@mail.ru" , Password = "345678"});



