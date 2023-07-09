namespace ADO.NET_HW_2.Models
{
    internal class Fruis
    {
        public string Id       { get; set; }
        public string Name     { get; set; }
        public string Color    { get; set; }
        public string FullName { get => ToString(); }
        public int    Calories { get; set; }

        public override string ToString() =>
             $"ID: {Id}###Name: {Name}###Color: {Color}###Calories: {Calories}";
    }
}
