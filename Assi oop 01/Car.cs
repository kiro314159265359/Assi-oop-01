using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assi_oop_01
{
    internal class Car
    {
        #region Attributes and prop
        private int _id;
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }



        #endregion

        //public Car()
        //{
        //    // do nothing
        //}
        // constructor chaining when adding a constructor inside a constructor
        public Car(int id , int speed , string model) :this(id , speed)// when adding constructor it cancel the default
        {
            //_id = id;
            //this.speed = speed;
            this.model = model;
        }
        public Car(int id, int speed) :this(id)
        {
            //_id = id;
            this.speed = speed;
        }
        public Car(int id)
        {
            _id = id;
        }

        public override string ToString()
        {
            return $"ID : {Id}  , Model : {Model} , Speed {speed}";
        }
    }
}
