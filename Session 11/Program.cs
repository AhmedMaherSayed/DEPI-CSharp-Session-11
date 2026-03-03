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
            var person1 = new
            {
                Name = "Ahmed",
                Age = 50,
                Phone = 0111111111111,
                Salary = 1_200
            };

            var person2 = new
            {
                Name = "Ali",
                Age = 50,
                Phone = 0111111111111,
                Salary = 1_200
            };
            Console.WriteLine(person1.Name);
            #endregion
        }
    }
}
