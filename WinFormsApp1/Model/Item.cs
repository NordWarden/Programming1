using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1.Model
{
    class Item
    {
        private static int _idCounter = 0;
        private readonly int _id;
        private string _name;
        private string _info;
        private float _cost;

        public Item(int id, string name, string Info, float cost)
        {
            _id = ++_idCounter;
            _name = name;
            _info = Info;
            _cost = cost;
        }

        public int Id => _id;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length > 200)
                    throw new ArgumentException("Название товара не может превышать 200 символов.");
                _name = value;
            }
        }


        public string Info
        {
            get => _info;
            set
            {
                if (value.Length > 1000)
                    throw new ArgumentException("Описание товара не может превышать 1000 символов.");
                _info = value;
            }
        }
        public float Cost
        {
            get => _cost;
            set
            {
                if (value < 0 || value > 100000)
                    throw new ArgumentException("Стоимость товара должна быть в пределах от 0 до 100 000.");
                _cost = value;
            }
        }

    }
}


