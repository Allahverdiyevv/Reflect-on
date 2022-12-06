using System.Reflection;

namespace Reflectıon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher= new Teacher(); 
           Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (Type type in assembly.GetTypes())
            {
                if (type == typeof(Teacher))
                {
                    Console.WriteLine("Types : ");
                    Console.WriteLine("\t " + type.Name);
                    Console.WriteLine("Propeties:");
                    foreach (PropertyInfo property in type.GetProperties())
                    {
                        Console.WriteLine(property);

                    }
                    Console.WriteLine("Field:");
                    foreach (FieldInfo field in type.GetFields(BindingFlags.Public |
                        BindingFlags.NonPublic | BindingFlags.Instance))
                    {
                        if (field.Name == "_name")
                        {
                            field.SetValue(teacher, "AB102");
                        }
                        Console.WriteLine("\t" + field.Name + " _ " + field.GetValue(teacher));

                    }
                }


            }
        }
    }
}