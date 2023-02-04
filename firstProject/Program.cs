using System;
using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Threading.Channels;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;


namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.WriteLine("I like c# programming");
            // input and output
            Console.Write("Hey!"); //continue in one line
            Console.WriteLine("Hello!"); // output create a new line

            //int x = 43; // declaration->initialization
            //int y; // declaration
            //y = 321;// initialize

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int z = x + y;
            //Console.WriteLine(z);

            //int age = 29;
            //Console.WriteLine("Your age is " + age);

            //double heigth = 23.4;
            //Console.WriteLine("Your height is " + heigth);

            //bool isRainy = true;
            //Console.WriteLine("are today rainy " + isRainy);

            //char symbol = '@';
            //Console.WriteLine("your symbol is " + symbol);

            //String name = "Tarmizi";
            //Console.WriteLine("Hello " + name);

            //String userName = symbol + name;
            //Console.WriteLine("Your userName is " + userName);

            //constant 
            /*
             * immutable values which are known at compile time
             * and do not change for the life of the program
             */
            //const double pi = 3.14159;

            // type casting
            /*
             * converting a value to a different data type useful when
             * we accept user input(string)
             * different data types ca do different things
             */
            //double a = 3.14;
            //int b = Convert.ToInt32(a);
            //Console.WriteLine(b.GetType());// display the data type


            //int c = 123;
            //double d = Convert.ToDouble(c);
            //Console.WriteLine(d);

            //int e = 321;
            //String f = Convert.ToString(e);
            //Console.WriteLine(f.GetType());

            //String g = "$";
            //char h = Convert.ToChar(g);
            //Console.WriteLine(h.GetType());

            //String i = "true";
            //bool j = Convert.ToBoolean(i);
            //Console.WriteLine(j.GetType());


            //Console.WriteLine("What's your name?");

            //String name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            //Console.WriteLine("What's your age?");

            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("My age is " + age);

            //int friends = 5;
            //friends = friends + 1;
            //friends += 2;
            //friends++;
            //Console.WriteLine(friends);

            //double x = 3.99;
            //double y = 5;
            //double a = Math.Pow(x, 3);
            //double b = Math.Sqrt(x);
            //double c = Math.Abs(x);
            //double d = Math.Round(x);
            //double e = Math.Ceiling(x);
            //double f = Math.Floor(x);
            //double g = Math.Max(x, y);
            //double h = Math.Min(x, y);

            //Console.WriteLine(g);


            // create random number
            //Random random = new Random();
            //int num = random.Next(1,21);

            //double num = random.NextDouble();
            //Console.WriteLine(num);

            //Console.WriteLine("Enter side A: ");
            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter side B: ");
            //double b = Convert.ToDouble(Console.ReadLine());

            //double c = Math.Sqrt((a * a) + (b * b));

            //Console.WriteLine("The hypotenuse is " + c);

            //String fullName = "Tarmizi";
            //String phoneNumber = "123-4567-890";

            //fullName = fullName.ToUpper();
            //Console.WriteLine(fullName);

            //phoneNumber= phoneNumber.Replace('-', '/');

            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0, "Mr.");

            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            //String firstName = fullName.Substring(0, 3);
            //Console.WriteLine(firstName);


            // decision making using if statement
            //Console.WriteLine("Please enter your age? ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age >= 18)
            //{
            //    Console.WriteLine("You're old enough to go to university");
            //}
            //else if(age<=0)
            //{
            //    Console.WriteLine("You're not born yet");
            //}
            //else
            //{
            //    Console.WriteLine("You're still in secondary school");
            //}

            //Console.WriteLine("Please enter your name");
            //String name = Console.ReadLine();

            //if (name != "")
            //{
            //    //Console.WriteLine("Hello " + name);
            //    Console.WriteLine("You did not enter your name here");
            //}
            //else
            //{
            //   // Console.WriteLine("Hello " + name);
            //    Console.WriteLine("You did not enter your name here");
            //}


            // alternative to if else statements
            //Console.WriteLine("What day today is? ");
            //String day = Console.ReadLine();

            //switch (day)
            //{
            //    case "Monday":
            //        Console.WriteLine("It's monday");
            //        break;
            //    case "Tuesday":
            //        Console.WriteLine("It's tuesday");
            //        break;
            //    case "Wednesday":
            //        Console.WriteLine("It's wednesday");
            //        break;
            //    case "Thursday":
            //        Console.WriteLine("It's thursday");
            //        break;
            //    case "Friday":
            //        Console.WriteLine("It's Friday");
            //        break;
            //    case "Saturday":
            //        Console.WriteLine("It's Saturday");
            //        break;
            //    case "Sunday":
            //        Console.WriteLine("It's Sunday");
            //        break;
            //    default:
            //        Console.WriteLine(day + "Invalid day");
            //        break;
            //}

            // logical operator = can be use to check if more than 1 condition is true/false
            // && (AND)
            // || (OR)
            //Console.WriteLine("What is temperature outside");
            //double temp = Convert.ToDouble(Console.ReadLine());

            //if (temp >= 10 && temp <= 25)
            //{
            //    Console.WriteLine("Slightly cold");
            //} else if (temp >= 26 && temp <= 35)
            //{
            //    Console.WriteLine("It's warm outside");
            //}
            //else
            //{
            //    Console.WriteLine("Don't forget to wear your jacket");
            //}

            //String name = "";

            //while (name == "")
            //{
            //    Console.WriteLine("Please enter your name: ");
            //    name = Console.ReadLine();
            //}

            //Console.WriteLine($"Hi {name}");

            // for loop repeats some code a finite amount of times

            //for (int i = 0; i <10; i++ )
            //{
            //    Console.WriteLine("Number " + i);
            //}

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Happy New Year!");


            // nested loops = loops inside of other loops
            //use vary. Used a lot in sorting algorithms

            //Console.WriteLine("How many rows");
            //int row = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter how many column");
            //int col = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("what symbol do you want to use");
            //String symbol = Console.ReadLine();

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.Write(symbol);
            //    }
            //    Console.WriteLine();
            //}


            //Random random = new Random();
            //bool playAgain = true;
            //int min = 1;
            //int max = 100;

            //int guess;
            //int number;
            //int guesses;
            //String response;

            //while (playAgain)
            //{
            //    guess = 0;
            //    guesses = 0;
            //    response = "";
            //    number = random.Next(min, max + 1);


            //    while (guess != number)
            //    {
            //        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
            //        guess = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Guess: " + guess);

            //        if (guess > number)
            //        {
            //            Console.WriteLine(guess + " is too high");
            //        } else if (guess < number)
            //        {
            //            Console.WriteLine(guess + " is too low");
            //        }

            //        guesses++;
            //    }

            //    Console.WriteLine("Number : " + number);
            //    Console.WriteLine("YOU WIN!");
            //    Console.WriteLine("Guesses: " + guesses);

            //    Console.WriteLine("Would you like to play again? Y/N");
            //    response=Console.ReadLine();
            //    response = response.ToUpper();

            //    if (response == "Y")
            //    {
            //        playAgain = true;
            //    }
            //    else
            //    {
            //        playAgain = false;
            //    }
            //}


            //Console.WriteLine("Thanks for playing! ....I guess");

            //Random random = new Random();
            //bool playAgain = true;
            //String player;
            //String computer;
            //String answer;

            //while (playAgain)
            //{

            //    player = "";
            //    computer = "";
            //    answer = "";

            //    while (player != "ROCK" && player !="PAPER" && player != "SCISSORS")
            //    {
            //        Console.WriteLine("Enter Rock, Paper, Scissors");
            //        player = Console.ReadLine();
            //        player = player.ToUpper();

            //    }

            //    switch (random.Next(1, 4))
            //    {
            //        case 1:
            //            computer = "ROCK";
            //            break;
            //        case 2:
            //            computer = "PAPER";
            //            break;
            //        case 3:
            //            computer = "SCISSORS";
            //            break;
            //    }

            //    Console.WriteLine("Player: " + player);
            //    Console.WriteLine("Computer: " + computer);

            //    switch (player)
            //    {
            //        case "ROCK":
            //            if (computer == "ROCK")
            //            {
            //                Console.WriteLine("It's a draw");
            //            }
            //            else if (computer == "PAPER")
            //            {
            //                Console.WriteLine("You lose");
            //            }
            //            else
            //            {
            //                Console.WriteLine("You Win!");
            //            }
            //            break;
            //        case "PAPER":
            //            if (computer == "ROCK")
            //            {
            //                Console.WriteLine("You Win!");
            //            }
            //            else if (computer == "PAPER")
            //            {
            //                Console.WriteLine("it's a draw");
            //            }
            //            else
            //            {
            //                Console.WriteLine("You lose");
            //            }
            //            break;
            //        case "SCISSORS":
            //            if (computer == "ROCK")
            //            {
            //                Console.WriteLine("You lose");
            //            }
            //            else if (computer == "PAPER")
            //            {
            //                Console.WriteLine("You win");
            //            }
            //            else
            //            {
            //                Console.WriteLine("i's a draw");
            //            }
            //            break;
            //    }

            //    Console.WriteLine("WOuld you like to play again Y/N");
            //    answer = Console.ReadLine();
            //    answer = answer.ToUpper();

            //    if (answer == "Y")
            //    {
            //        playAgain = true;
            //    }
            //    else
            //    {
            //        playAgain = false;
            //    }

            //}

            //Console.WriteLine("Thanks for playing");

            //do
            //{

            //    double num1 = 0;
            //    double num2 = 0;
            //    double result = 0;


            //    Console.WriteLine("------------------");
            //    Console.WriteLine("Calculator Program");
            //    Console.WriteLine("------------------");

            //    Console.WriteLine("Please enter number 1: ");
            //    num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Please enter number 2: ");
            //    num2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Enter an option: ");
            //    Console.WriteLine("\t+ : Add");
            //    Console.WriteLine("\t- : Subs");
            //    Console.WriteLine("\t* : Mult");
            //    Console.WriteLine("\t/ : Divs");
            //    Console.Write("Enter an option: ");

            //    switch (Console.ReadLine())
            //    {
            //        case "+":
            //            result = num1 + num2;
            //            Console.WriteLine($"Your result is : {num1} + {num2} = " + result);
            //            break;
            //        case "-":
            //            result = num1 - num2;
            //            Console.WriteLine($"Your result is : {num1} - {num2} = " + result);
            //            break;
            //        case "*":
            //            result = num1 * num2;
            //            Console.WriteLine($"Your result is : {num1} * {num2} = " + result);
            //            break;
            //        case "/":
            //            result = num1 / num2;
            //            Console.WriteLine($"Your result is : {num1} / {num2} = " + result);
            //            break;
            //        default:
            //            Console.WriteLine("that was not a valid option");
            //            break;

            //    }

            //    Console.WriteLine("Would you like to continue? Y/N");
            //} while (Console.ReadLine().ToUpper() == "Y");

            //Console.WriteLine("bye");

            // array = a variable that can store multiple value.fixed size
            /*
            String[] cars = new string[3];

            cars[0] = "Mercedes";
            cars[1] = "lambo";
            cars[2] = "Range Rover";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            String[] car = { "BMW", "Proton", "Perodua", "Mustang"};
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);
            Console.WriteLine(car[3]);

            car[0] = "Honda";
            Console.WriteLine(car[0]);

            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }


            // foreach loop = a simpler way to iterate over an array, but it's less flexible
            foreach (var car1 in cars)
            {
                Console.WriteLine("I have bought car model {0}", car1);
            }
            */


            // method = perform a section of code, whenever it's called 'invoked'.
            // benefit = let's us reuse code w/o writing it multiple times
            //String name = "Bro";
            //int age = 29;

            //singHappyBirthday(name,age);
            //singHappyBirthday(name, age);

            // return keyword = return data back to the place where a method is invoked
            //double x;
            //double y;
            //double result;




            //Console.WriteLine("Please enter input 1: ");
            //x = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please enter input y: ");
            //y = Convert.ToDouble(Console.ReadLine());

            //result = Multiply(x, y);

            //Console.WriteLine(result);


            // method overloading = method share the same name, but different parameters
            // name + parameters = signature
            // methods must have unique signature

            //

            //double total;

            //total = Multiply(2, 3, 4);

            //Console.WriteLine(total);

            // params keyword = a method parameter that takes a variable number of arguments.
            // the parameter type must be a single - dimensional array

            //double total = CheckOut(3.99, 5.75, 15);

            //Console.WriteLine(total);

            // exception = errors that occur during execution
            // try = try some code that is considered "dangerous"
            // catch = catches and handles exceptions when they occur
            // finally = always executes regardless if exception is caught or not

            //double x;
            //double y;
            //double result;

            //try
            //{


            //    Console.WriteLine("Please enter the input 1:");
            //    x = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Please enter input 2: ");
            //    y = Convert.ToDouble(Console.ReadLine());



            //    result = x / y;

            //    Console.WriteLine(result);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Enter only number please");
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("You cannot divide by 0");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Something went wrong");
            //}
            //finally
            //{
            //    Console.WriteLine("Thanks for visiting");
            //}

            // conditional operator
            // (condition) ? x :y

            //double temp = 20;
            //string message;

            //if (temp >= 15)
            //{
            //    message = "It's warm outside";
            //}
            //else
            //{
            //    message = "It's cold outside";
            //}

            //Console.WriteLine(message);

            //message =temp >= 15 ? "It's warm outside" : "It's cold outside";
            //Console.WriteLine(message);

            // string interpolation = allows us to insert variables into a string literal
            // precede a string literal with $
            // {} are placeholders

            //String firstName = "Tarmizi";
            //String lastName = "Ismail";
            //int age = 29;

            //Console.WriteLine("Hello " + firstName + " " + lastName + " ");
            //Console.WriteLine($"Hello {firstName} {lastName}");
            //Console.WriteLine($"You're {age,10} years old");

            // multidimensional arrays
            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyota = { "Corolla", "Camry", "Rav4" };

            String[,] parkingLot =
            {
                { "Mustang", "F-150", "Explorer" },
                { "Corvette", "Camaro", "Silverado" },
                { "Corolla", "Camry", "Rav4" }
            };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";
            /*
            foreach (var car in parkingLot)
            {
                Console.WriteLine(car);
            }

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.WriteLine(parkingLot[i,j] + " ");
                }

                Console.WriteLine();
            }
            */

            /*
             * class -> a bundle of related code.
             * can be used as a blueprint to create objects (oop)
             */

            //messages.Hello();
            //messages.Waiting();
            //messages.Bye();

            /*
             * object -> an instance of a class
             * a class can be used as a blueprint to create object (OOP)
             * objects can have fields & methods (characteristic and actions)
             */

            /*
             * constructor = a special method in class
             * same name as the class name
             * can be used to assign arguments to fields when creating an object
             */

            //Human me = new Human("mizi", 29);
            //Human you = new Human("ismail", 74);


            //me.name = "Tarmizi";
            //me.age = 29;

            //me.Eat();
            //me.Sleep();

            //you.name = "Ismail";
            //you.age = 29;

            //you.Eat();
            //you.Sleep();
            //Car myCar = new Car("Toyota", "Vios", 2021, "Red Mica");
            //Car car2 = new Car("Perodua", "Bezza", 2017, "Ocean Blue");

            //myCar.Drive();
            //car2.Drive();

            /*
             * static = modifier to declare a static member, which belong to the class itself
             * rather than to any specific object
             */

            //Car car1 = new Car("Mustang");
            //Car car2 = new Car("Corvette");
            //Car car3 = new Car("Perodua");

            //Console.WriteLine(Car.numberOfCars);

            //Car.StartRace();

            /* overloading constructor = technique to create multiple constructor, with
             a different set parameters. name + parameters = signature*/

            //Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");

            /*
             * inheritance = 1 or more child classes receiving field, methods, etc. from common parent
             */
            //Car car = new Car();

            //Bicycle bicycle = new Bicycle();

            //Boat boat = new Boat();

            //Console.WriteLine(car.speed);
            //Console.WriteLine(car.wheels);
            //car.go();

            //Console.WriteLine(bicycle.speed);
            //Console.WriteLine(bicycle.wheels);
            //bicycle.go();

            //Console.WriteLine(boat.speed);
            //Console.WriteLine(boat.wheels);
            //boat.go();

            /*
             * abstract classes = modifier that indicates missing components or incomplete implementation
             */

            //Car[] garage = new Car[3];

            //Car car1 = new Car("lambo");
            //Car car2 = new Car("vios");
            //Car car3 = new Car("Spectra");

            //garage[0] = car1;
            //garage[1] = car2;
            //garage[2] = car3;

            //Console.WriteLine(garage[0].model);
            //Console.WriteLine(garage[1].model);
            //Console.WriteLine(garage[2].model);

            //foreach (Car car in garage)
            //{
            //    Console.WriteLine(car.model);
            //}

            /*
             * anonymous object
             */

            //Car[] garage2 = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

            //foreach (Car car in garage2)
            //{
            //    Console.WriteLine(car.model);                
            //}

            /*
             * object as argument
             */

            //Car car1 = new Car("Vios", "Red");
            //ChangeColor(car1, "Blue");

            //Car car2 = Copy(car1);
            //Console.WriteLine(car1.color + " " + car1.model);

            /*
             * methods overriding = provides a new version of a method inherited from a parent class
             * inherited method must be: abstract, virtual, or already overriden
             * used with ToString(), polymorphism
             */
            //Dog dog = new Dog();
            //Cat cat = new Cat();

            //dog.Speak();
            //cat.Speak();

            /*
             * ToString() = converts an object to its string representation so that it is suitable for display
             */

            //Car car = new Car("Vios", "Toyota", 2021, "Red");

            //Console.WriteLine(car.ToString());

            /*
             * polymorphism = objects can be identified by more than one type
             * ex. a dog is also:canine, animal, organism
             */

            //Car car = new Car();
            //Bicycle bicycle = new Bicycle();
            //Boat boat = new Boat();

            //Vehicle[] races =
            //{
            //    car, bicycle, boat
            //};

            //foreach (Vehicle vehicle in races)
            //{
            //    vehicle.Go();
            //}


            /*
             * interfaces = defines a "contract" that all the classes inheriting from should follow
             * an interface declares "what a class should have"
             * an inheriting class defines "how it should dp it"
             * Benefit = security + multiple inheritance + plug n play
             */

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Hunt();
            fish.Flee();


            /*
             * List = data structure that represent a list of objects that can be accessed by index
             * similar to array, but can dynamically increase/decrease in size
             * using system.Collections.Generic;
             */

            //String[] food = new String[3];

            //food[0] = "burger";
            //food[1] = "maggie";
            //food[2] = "mamee";

            //List<String> food1 = new List<String>();

            //food1.Add("Pizza");
            //food1.Add("Hamburger");
            //food1.Add("Maggie");
            //food1.Add("hotdog");

            //Console.WriteLine(food1[0]);
            //Console.WriteLine(food1[1]);

            //food1.Remove("Pizza");

            //food1.Insert(0, "Sushi");
            //Console.WriteLine(food1.Count);
            //Console.WriteLine(food1.IndexOf("Pizza"));
            //Console.WriteLine(food1.Contains("Pizza"));
            //food1.Sort();
            //food1.Reverse();
            //food1.Clear();

            //String[] foodArray = food1.ToArray();

            //foreach (var item in food1)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Player> players = new List<Player>();

            //Player player1 = new Player("me");
            //Player player2 = new Player("Mizi");
            //Player player3 = new Player("Mz");


            //players.Add(player1);
            //players.Add(player2);
            //players.Add(player3);

            //foreach (Player player in players)
            //{
            //    Console.WriteLine(player);
            //}


            /*
             * getter and setter = add security to field by encapsulation they're accessors found within properties
             * properties = combine aspects of both fields and method (share name with a field)
             * get accessor = used to return the property value
             * get accessor = used to assign a new value
             * value keyword = defines the values being assign by the set (parameter)
             */

            //Car2 car = new Car2(400);

            //car.Speed = 1000;
            //Console.WriteLine(car.Speed);

            /*
             * auto implemented property = shortcut when no additional logic is required in the property
             * you do not have to define a field for a property, you only have to write get; and/or set; inside property
             */


            /*
             * enums = special "class" that contains a set of named integer constant.
             * use enums when you have values that you know will not change,
             * to get the integer value from an item, you must explicitly convert to an int
             *
             * name = integer
             * same thing as tostring()
             */


            //Console.WriteLine(Planets.Venus + " is a planet #" + (int)Planets.Venus);
            //String name = PlanetRadius.Earth.ToString();
            //int radius = (int)PlanetRadius.Earth;
            //double volume = Volume(PlanetRadius.Earth);


            //Console.WriteLine("planet : " + name);
            //Console.WriteLine("radius " + radius + "km");
            //Console.WriteLine("volume " + volume);


            /*
             * generic = not specific to a particular data type.
             * add<T> to: classes, method, fields etc.
             * allows for code reusebility for a different data types
             *
             */

            //int[] intArray = {1,2,3 };
            //double[] doubleArray = {1.0,2.0,3.0 };
            //String[] stringArray = { "1", "2", "3"};


            //displayElement(intArray);
            //displayElement(doubleArray);
            //displayElement(stringArray);

            /*
             * thread = an execution path of a program
             * we can use multiple threads to perform,
             * different task of our program at the same time.
             * current thread running is "main" thread
             * using system.threading
             */

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = " Main Thread";
            Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);

            thread1.Start();
            thread2.Start();

            //CountDown();
            //CountUp();
            Console.WriteLine(mainThread.Name + " Is completed");




            Console.ReadKey(); // hide the message in console


        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1  ; " + i + " seconds");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Timer #1 is complete");
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2  ; " + i + " seconds");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Timer #2 is complete");
        }
        //public static void displayElement<T>(T[] array)
        //{
        //    foreach (T item in array)
        //    {
        //        Console.WriteLine(item + " ");
        //    }

        //    Console.WriteLine();
        //}
        //public static double Volume(PlanetRadius radius)
        //{
        //    double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        //    return volume;
        //}

        //public static Car Copy(Car car)
        //{
        //    return new(car.model, car.color);
        //}
        //public static void ChangeColor(Car car, String color)
        //{
        //    car.color = color;
        //}
        //static double CheckOut(params double[] prices)
        //{
        //    double total = 0;
        //    foreach (double price in prices)
        //    {
        //        total = total + price;
        //    }

        //    return total;
        //}

        //static double CheckOut(double a , double b)
        //{
        //    return a + b;
        //}

        //static double CheckOut(double a, double b, double c)
        //{
        //    return a + b + c;
        //}

        //static double CheckOut(double a, double b, double c, double d)
        //{
        //    return a + b + c +d;
        //}

        //static double Multiply(double x, double y)
        //{
        //    return x * y;
        //}

        //static double Multiply(double x, double y, double z)
        //{
        //    return x * y * z;
        //}

        //static double Multiply(double x, double y)
        //{
        //    double z = x * y;
        //    return z;
        //}

        //static void singHappyBirthday(String name, int age)
        //{
        //    Console.WriteLine("Happy Birthday to you!");
        //    Console.WriteLine("Happy Birthday to you!");
        //    Console.WriteLine($"Happy Birthday to dear {name}!");
        //    Console.WriteLine("Your age is {0}", age);
        //    Console.WriteLine("Happy Birthday to you!");
        //    Console.WriteLine();
        //}
    }

    enum Planets
    {
        Mercury =1,
        Venus, 
        Earth, 
        Mars, 
        Jupiter, 
        Saturn,
        Uranus, 
        Neptune, 
        Pluto
    }

    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
    //class Car3
    //{

    //    public String Model { get; set; }
    //}
    //class Car2
    //{
    //    private int speed;

    //    public Car2(int speed)
    //    {
    //        Speed = speed;
    //    }

    //    public int Speed
    //    {
    //        get
    //        {
    //            return speed;// read 
    //        }
    //        set
    //        {
    //            if (value > 500)
    //            {
    //                speed = 500;
    //            }
    //            else
    //            {
    //                speed = value;
    //            }
    //        }
    //    }
    //}
    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }


    
    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs a way");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("the hawk is searching for food");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swam away");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching for food");
        }
    }
    class Vehicle
    {
        public virtual void Go()
        {

        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving");
        }
    }
    //class Car
    //{
    //    public String make;
    //    public String model;
    //    public int year;
    //    public String color;

    //    public Car(String make, String model, int year, String color)
    //    {
    //        this.make = make;
    //        this.model = model;
    //        this.year = year;
    //        this.color = color;
    //    }

    //    public override string ToString()
    //    {
    //        String message = "This is a " + make + " " + model;
    //        return message;
    //    }
    //}

    //class Animal
    //{
    //    public virtual void Speak()
    //    {
    //        Console.WriteLine("the animal goes *brrr*");
    //    }
    //}

    //class Dog : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("The dog goes *wooofff*");
    //    }
    //}

    //class Cat : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("The cat goes meow");
    //    }

    //}
    //class Car
    //{
    //    public String model;
    //    public String color;


    //    public Car(String model, string color)
    //    {
    //        this.model = model;
    //        this.color = color;
    //    }
    //}

    //abstract class Vehicle
    //{
    //    public int speed = 0;

    //    public void go()
    //    {
    //        Console.WriteLine("This vehicle is moving");
    //    }
    //}

    //class Car : Vehicle
    //{
    //    public int wheels = 4;
    //    private int maxSpeed = 300;
    //}

    //class Bicycle : Vehicle
    //{
    //    public int wheels = 2;
    //    private int maxSpeed = 50;
    //}

    //class Boat : Vehicle
    //{
    //    public int wheels = 0;
    //    private int maxSpeed = 200;
    //}

    //class Pizza
    //{
    //    public String bread;
    //    public String sauce;
    //    public String cheese;
    //    public String topping;

    //    public Pizza(String bread, String sauce, String cheese, String topping)
    //    {
    //        this.bread = bread;
    //        this.sauce = sauce;
    //        this.cheese = cheese;
    //        this.topping = topping;
    //    }

    //    public Pizza(String bread, String sauce, String cheese)
    //    {
    //        this.bread = bread;
    //        this.sauce = sauce;
    //        this.cheese = cheese;
    //    }

    //    public Pizza(String bread, String sauce)
    //    {
    //        this.bread = bread;
    //        this.sauce = sauce;
    //    }
    //    public Pizza(String bread)
    //    {
    //        this.bread = bread;
    //    }
    //}

    //class Human
    //{
    //    //property of an object
    //    public String name;
    //    public int age;


    //    public Human(String name , int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }

    //    // method of the object
    //    public void Eat()
    //    {
    //        Console.WriteLine(name + " is eating");
    //    }

    //    public void Sleep()
    //    {
    //        Console.WriteLine(name + " is sleeping");
    //    }



    //}

    //class Car
    //{
    //    public String make;
    //    public String model;
    //    public int year;
    //    public String color;


    //    public Car(String make, String model, int year, String color)
    //    {
    //        this.make = make;
    //        this.model = model;
    //        this.year = year;
    //        this.color = color;
    //    }

    //    public void Drive()
    //    {
    //        Console.WriteLine($"You're driving {make} model {model} {color} color, this car made in {year}.");
    //    }
    //}

    //class Car
    //{
    //    public String model;
    //    public static int numberOfCars;

    //    public Car(String model)
    //    {
    //        this.model = model;
    //        numberOfCars++;
    //    }

    //    public static void StartRace()
    //    {
    //        Console.WriteLine("The race has begun");
    //    }
    //}
}