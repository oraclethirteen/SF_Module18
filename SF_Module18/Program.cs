using System;
using System.Collections.Generic;
using System.Text;

namespace SF_Module18
{
    class Program
    {
        static void Main(string[] args)
        {
            // [18.1.1]
            /*
            var carPlant = new CarPlant();

            Conveyor builder = new ScooterConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            builder = new CarConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            builder = new MotoConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();
            */

            // [18.1.6]
            /*
            BaseClass myObject = new ImplementationOne(1);
            myObject.GetId();

            BaseClass clone = myObject.Clone();
            clone.GetId();

            myObject = new ImplementationTwo(2);
            myObject.GetId();

            clone = myObject.Clone();
            clone.GetId();
            */

            // [18.2.5]
            /*
            Pult pult = new Pult();
            Gate gate = new Gate();

            pult.SetAction(new GateOpenAction(gate));
            pult.OpenButton();
            pult.CloseButton();
            */
        }

        // [18.1.1]
        /*
        public abstract class Conveyor
        {
            protected Product _product;

            public Product Product
            {
                get { return _product; }
            }

            public abstract void BuildFrame();
            public abstract void BuildEngine();
            public abstract void BuildWheels();
            public abstract void BuildDoors();
        }

        public class Product
        {
            private string _type;

            private Dictionary<string, string> _parts = new Dictionary<string, string>();
 
            public Product(string type)
            {
                _type = type;
            }

            public string this[string key]
            {
                set
                {
                    _parts[key] = value;
                }
            }

            public void Show()
            {
                Console.WriteLine();
                Console.WriteLine($"Вид транспортного средства: {_type}");
                Console.WriteLine($" Рама : {_parts["frame"]}");
                Console.WriteLine($" Двигатель : {_parts["engine"]}");
                Console.WriteLine($" Колеся: {_parts["wheels"]}");
                Console.WriteLine($" Двери : {_parts["doors"]}");
            }
        }

        public class CarPlant
        {
            public void Construct(Conveyor conveyor)
            {
                conveyor.BuildFrame();
                conveyor.BuildEngine();
                conveyor.BuildWheels();
                conveyor.BuildDoors();
            }
        }

        public class CarConveyor : Conveyor
        {
            public CarConveyor()
            {
                _product = new Product("Автомобиль");
            }

            public override void BuildFrame()
            {
                _product["frame"] = "Рама автомобиля";
            }

            public override void BuildEngine()
            {
                _product["engine"] = "150 л.с.";
            }

            public override void BuildWheels()
            {
                _product["wheels"] = "4";
            }

            public override void BuildDoors()
            {
                _product["doors"] = "4";
            }
        }

        public class MotoConveyor : Conveyor
        {
            public MotoConveyor()
            {
                _product = new Product("Мотоцикл");
            }

            public override void BuildFrame()
            {
                _product["frame"] = "Рама мотоцикла";
            }

            public override void BuildEngine()
            {
                _product["engine"] = "70 л.с.";
            }

            public override void BuildWheels()
            {
                _product["wheels"] = "2";
            }

            public override void BuildDoors()
            {
                _product["doors"] = "0";
            }
        }

        public class ScooterConveyor : Conveyor
        {
            public ScooterConveyor()
            {
                _product = new Product("Скутер");
            }

            public override void BuildFrame()
            {
                _product["frame"] = "Рама скутера";
            }

            public override void BuildEngine()
            {
                _product["engine"] = "25 л.с.";
            }

            public override void BuildWheels()
            {
                _product["wheels"] = "2";
            }

            public override void BuildDoors()
            {
                _product["doors"] = "0";
            }
        }
        */

        // [18.1.6]
        /*
        public abstract class BaseClass
        {
            public int Id { get; }

            public BaseClass(int id)
            {
                Id = id;
            }

            public void GetId()
            {
                Console.WriteLine($"Создан объект с Id {Id}");
            }

            public abstract BaseClass Clone();
        }

        public class ImplementationOne : BaseClass
        {
            public ImplementationOne(int id) : base(id)
            { }

            public override BaseClass Clone()
            {
                return new ImplementationOne(Id);
            }
        }

        public class ImplementationTwo : BaseClass
        {
            public ImplementationTwo(int id) : base(id)
            { }

            public override BaseClass Clone()
            {
                return new ImplementationTwo(Id);
            }
        }
        */

        // [18.2.5]
        /*
        public class Gate
        {
            public void Open()
            {
                Console.WriteLine("Открываем ворота");
            }

            public void Close()
            {
                Console.WriteLine("Закрываем ворота");
            }
        }

        public interface IAction
        {
            void Run();
            void Undo();
        }

        public class GateOpenAction : IAction
        {
            Gate _gate;

            public GateOpenAction(Gate gateSet)
            {
                _gate = gateSet;
            }

            public void Run()
            {
                _gate.Open();
            }

            public void Undo()
            {
                _gate.Close();
            }
        }

        public class Pult
        {
            IAction _action;

            public void SetAction(IAction action)
            {
                _action = action;
            }

            public void OpenButton()
            {
                _action.Run();
            }

            public void CloseButton()
            {
                _action.Undo();
            }
        }
        */
    }
}