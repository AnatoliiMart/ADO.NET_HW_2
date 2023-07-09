using ADO.NET_HW_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;

namespace ADO.NET_HW_2
{
    public partial class Form1 : Form
    {
        private readonly DbVegs_Fruits _db;
        private readonly Dictionary<string, string> _tasks;
        private List<Fruis> _fruits; 
        private List<Vegetables> _vegetables;
        private Action _action;
       
        public Form1()
        {
            _db = new DbVegs_Fruits();
            _tasks = new Dictionary<string, string>()
        {
            {"3.1", "Отображение всей информации из таблицы с овощами и фруктами;" },
            {"3.2", "Отображение всех названий овощей и фруктов;" },
            {"3.3", "Отображение всех цветов;" },
            {"3.4", "Показать максимальную калорийность;" },
            {"3.5", "Показать минимальную калорийность;" },
            {"3.6", "Показать среднюю калорийность." },
            {"4.1", "Показать количество овощей;" },
            {"4.2", "Показать количество фруктов;" },
            {"4.3", "Показать количество овощей и фруктов заданного цвета;" },
            {"4.4", "Показать количество овощей фруктов каждого цвета;" },
            {"4.5", "Показать овощи и фрукты с калорийностью ниже указанной;" },
            {"4.6", "Показать овощи и фрукты с калорийностью выше указанной;" },
            {"4.7", "Показать овощи и фрукты с калорийностью в указанном диапазоне;" },
            {"4.8", "Показать все овощи и фрукты, у которых цвет желтый или красный." }
        };
            _fruits = new List<Fruis>();
            _vegetables = new List<Vegetables>();
            InitializeComponent();
            txtBox_Result.ReadOnly = true;
            cmbBox_Tasks.DataSource = _tasks.Keys.ToArray();
            cmbBox_Tasks.SelectedIndex = 0;
        }

        public void ShowAll()
        {
            Clear();
            _db.DivideOnVegsAndFruits(_db.CommandCreation(@"SELECT * FROM VegsFruits"), ref _fruits, ref _vegetables);
            ShowEnteredMember("FullName");
        }

        public void ShowOnlyNames()
        {
            Clear();
            string commandText = @"SELECT * 
                                   FROM VegsFruits";

            _db.DivideOnVegsAndFruits(_db.CommandCreation(commandText), ref _fruits, ref _vegetables);
            ShowEnteredMember("Name");
        }

        public void ShowOnlyColors()
        {
            Clear();
            string commandText = @"SELECT * 
                                   FROM VegsFruits";

            _db.DivideOnVegsAndFruits(_db.CommandCreation(commandText), ref _fruits, ref _vegetables);
            ShowEnteredMember("Color");
        }

        public void ShowMaxCalories()
        {
            Clear();
            string commandText = @"SELECT MAX(Calories) 
                                   FROM VegsFruits";

            txtBox_Result.Text = _db.CommandCreation(commandText).ExecuteScalar().ToString();
        }

        public void ShowMinCalories()
        {
            Clear();
            string commandtext = @"SELECT MIN(Calories)
                                   FROM VegsFruits";

            txtBox_Result.Text = _db.CommandCreation(commandtext).ExecuteScalar().ToString();
        }

        public void ShowAverageCalories()
        {
            Clear();
            string commandText = @"SELECT AVG(CONVERT(real, Calories)) 
                                   FROM VegsFruits";
            txtBox_Result.Text = _db.CommandCreation(commandText).ExecuteScalar().ToString();
        }


        public void ShowAmountOfVegs()
        {
            Clear();
            string commandText = @"SELECT COUNT(*)
                                   FROM VegsFruits
                                   WHERE Type = 'Vegetable'";

            txtBox_Result.Text = _db.CommandCreation(commandText).ExecuteScalar().ToString();
        }

        public void ShowAmountOfFruits()
        {
            Clear();
            string commandText = @"SELECT COUNT(*)
                                   FROM VegsFruits
                                   WHERE Type = 'Fruit'";

            txtBox_Result.Text = _db.CommandCreation(commandText).ExecuteScalar().ToString();
        }

        public void ShowAmountOfFruitsAndVegsConcreteColor()
        {
            Clear();
            string color = txtBox_ValueInput.Text;
            string commandText = $"SELECT COUNT(*) " +
                                 $"FROM VegsFruits" +
                                 $" WHERE Color = '{color}'";

            txtBox_Result.Text = _db.CommandCreation(commandText).ExecuteScalar().ToString();
        }

        public void ShowAmountOfFruitsAndVegsEachColor()
        {
            Clear();
            string commandText = $"SELECT COUNT(*), " +
                                 $"Color FROM VegsFruits" +
                                 $" GROUP BY Color";

            DbDataReader reader = _db.CommandCreation(commandText).ExecuteReader();
            List<string> values = new List<string>();

            while (reader.Read())
                values.Add($"Count: {reader[0]}\tColor: {reader[1]}");
            reader.Close();
           
            lstBoxFruits.DataSource = values;
        }

        public void ShowAmountOfFruitsAndVegsLowerByCalories()
        {
            Clear();
            int caloriesAmount = int.Parse(txtBox_ValueInput.Text);
            string commandText = $"SELECT * " +
                                 $"FROM VegsFruits" +
                                 $" WHERE Calories < {caloriesAmount}";

            _db.DivideOnVegsAndFruits(_db.CommandCreation(commandText), ref _fruits, ref _vegetables);
            ShowEnteredMember("FullName");
        }

        public void ShowAmountOfFruitsAndVegsHigerByCalories()
        {
            Clear();
            int caloriesAmount = int.Parse(txtBox_ValueInput.Text);
            string commandText = $"SELECT * " +
                                 $"FROM VegsFruits" +
                                 $" WHERE Calories > {caloriesAmount}";

            _db.DivideOnVegsAndFruits(_db.CommandCreation(commandText), ref _fruits, ref _vegetables);
            ShowEnteredMember("FullName");
        }

        public void ShowAmountOfFruitsAndVegsInSelectedRangeOfCalories()
        {
            Clear();
            int caloriesAmountLowerRange = int.Parse(txtBox_ValueInput.Text);
            int caloriesAmountUpperRange = int.Parse(txtBox_SecondValue.Text);

            string commandText = $"SELECT * " +
                                $"FROM VegsFruits" +
                                $" WHERE Calories BETWEEN {caloriesAmountLowerRange} AND {caloriesAmountUpperRange}";

            _db.DivideOnVegsAndFruits(_db.CommandCreation(commandText), ref _fruits, ref _vegetables);
            ShowEnteredMember("FullName");
        }

        public void ShowAmountOfFruitsAndVegsWithRedOrYellowColor()
        {
            Clear();
            string commandText = $"SELECT * " +
                                 $"FROM VegsFruits" +
                                 $" WHERE Color = 'Red' OR Color = 'Yellow'";

            _db.DivideOnVegsAndFruits(_db.CommandCreation(commandText), ref _fruits, ref _vegetables);
            ShowEnteredMember("FullName");
        }
        
        private void AddToDel()
        {
            _action += ShowAll;
            _action += ShowOnlyNames;
            _action += ShowOnlyColors;
            _action += ShowMaxCalories;
            _action += ShowMinCalories;
            _action += ShowAverageCalories;


            _action += ShowAmountOfVegs;
            _action += ShowAmountOfFruits;
            _action += ShowAmountOfFruitsAndVegsConcreteColor;
            _action += ShowAmountOfFruitsAndVegsEachColor;
            _action += ShowAmountOfFruitsAndVegsLowerByCalories;
            _action += ShowAmountOfFruitsAndVegsHigerByCalories;
            _action += ShowAmountOfFruitsAndVegsInSelectedRangeOfCalories;
            _action += ShowAmountOfFruitsAndVegsWithRedOrYellowColor;
        }

        private void cmbBox_Tasks_SelectedIndexChanged(object sender, EventArgs e) =>
            textBox_TaskText.Text = _tasks[cmbBox_Tasks.SelectedItem.ToString()];

        private void button1_Click(object sender, EventArgs e)
        {
            AddToDel();
            for (int i = 0; i <= _action.GetInvocationList().Length; i++)
                if (i == cmbBox_Tasks.SelectedIndex)
                {
                    Invoke(_action.GetInvocationList()[i]);
                    _action = null;
                    break;
                }
            
        }

        private void ShowEnteredMember(string memder)
        {
            lstBoxFruits.DataSource = _fruits;
            lstBoxFruits.DisplayMember = memder;
            lstBox_Vegetables.DataSource = _vegetables;
            lstBox_Vegetables.DisplayMember = memder;
        }

        private void Clear()
        {
            _fruits.Clear();
            _vegetables.Clear();
        }


    }
    
}
