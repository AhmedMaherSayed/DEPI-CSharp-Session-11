namespace Session_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Singelton Design Pattern
            //Car car = new Car()
            //{
            //    Id = 1,
            //    Model = "BMW"
            //}; 

            //Car car1 = Car.GetCar();

            //Console.WriteLine(car1.GetHashCode());
            //Car car2 = Car.GetCar();

            //Console.WriteLine(car2.GetHashCode());
            //Car car3 = Car.GetCar();

            //Console.WriteLine(car3.GetHashCode());
            #endregion

            #region Ananyomous Type
            //var person1 = new
            //{
            //    Name = "Ahmed",
            //    Age = 50,
            //    Phone = 0111111111111,
            //    Salary = 1_200
            //};

            //var person2 = new
            //{
            //    Name = "Ali",
            //    Age = 50,
            //    Phone = 0111111111111,
            //    Salary = 1_200
            //};
            //Console.WriteLine(person1.Name);
            #endregion

            #region Extension Methods
            //bool isGreaterThan = StringHelper.IsLongerThan("Ahmed", 13);
            //Console.WriteLine(isGreaterThan);

            //var name = "Ahmed";

            //var stringHelper = new StringHelper();

            //bool isGreaterThan = stringHelper.IsLongerThan(name, 3);

            //Console.WriteLine(name.IsLongerThan(13));
            #endregion

            #region Delegates

            var calculator = new Calculator();

            //Operation addOperation = MathOperation.Add;
            //Operation subOperation = MathOperation.Subtract;

            //Console.WriteLine(calculator.Calculate(10, 5, addOperation));
            //Console.WriteLine(calculator.Calculate(10, 5, subOperation));

            //int result = calculator.Calculate(10, 5, (a, b) => a - b);
            //Console.WriteLine(result);

            //Operation op = MathOperation.Add;
            //Console.WriteLine(calculator.Calculate(10, 5, op));

            //op += MathOperation.Subtract;
            //op += MathOperation.Multiply;
            //op += MathOperation.Divide;

            //var delgMathList = op.GetInvocationList();

            //op -= MathOperation.Divide;
            //Console.WriteLine(calculator.Calculate(10, 5, op));
            //op -= MathOperation.Multiply;
            //Console.WriteLine(calculator.Calculate(10, 5, op));
            //op -= MathOperation.Subtract;
            //Console.WriteLine(calculator.Calculate(10, 5, op));
            //op -= MathOperation.Add;
            //Console.WriteLine(calculator.Calculate(10, 5, op));
            //foreach(var delg in delgMathList)
            //{
            //    Console.WriteLine(calculator.Calculate(10, 5, op));

            //}

            #region Built-in delegates

            //1- Func<in T1,in T2, ...., out TResult>

            //Func<int, int, int> add = (a, b) => a + b;
            //Console.WriteLine(add(10, 5));

            //Func<string> getMessage = () => "Hello";
            //Console.WriteLine(getMessage.Invoke());

            //2- Predicate<in T>
            //Func<in T , bool out TResult>

            //Predicate<int> isEven = (x) => x % 2 == 0;
            ////Func<int, bool> isEven = (x) => x % 2 == 0;
            //Console.WriteLine(isEven(10));


            //3- Action<in T, ....>

            Action<string> print = message => Console.WriteLine(message);

            print("Hello");
            #endregion
            #endregion
        }
    }
}
