namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Type Example
            int valueType1 = 10;
            int valueType2 = valueType1; // Copying value
            valueType2 = 20; // Changing valueType2 does not affect valueType1
            Console.WriteLine($"Value Type: valueType1 = {valueType1}, valueType2 = {valueType2}");
            // Reference Type Example
            var referenceType1 = new Person { Name = "Alice" };
            var referenceType2 = referenceType1; // Copying reference
            referenceType2.Name = "Bob"; // Changing referenceType2 affects referenceType1
            Console.WriteLine($"Reference Type: referenceType1.Name = {referenceType1.Name}, referenceType2.Name = {referenceType2.Name}");
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}