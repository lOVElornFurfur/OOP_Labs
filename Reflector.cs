using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Reflection
{
    class Reflector<T>
    {
        public void ShowAll(T obj)
        {
            Type myType = obj.GetType();

            using (StreamWriter sw = new StreamWriter($"D:/Visual/note.txt", false))
            {
                foreach (MemberInfo mi in myType.GetMembers())
                {
                    sw.WriteLine($"{mi.DeclaringType} : {mi.MemberType} : {mi.Name}");
                }
                sw.WriteLine();
            }
        }
        public void GetPublicMethods(T obj)
        {
            Type myType = obj.GetType();

            using (StreamWriter sw = new StreamWriter($"D:/Visual/note.txt", true))
            {
                sw.WriteLine($"Public methods of class:");
                foreach (MemberInfo mi in myType.GetMethods())
                {
                    sw.WriteLine($"{mi.Name}");
                }
                sw.WriteLine();
            }
        }
        public void GetPropField(T obj)
        {
            Type myType = obj.GetType();

            using (StreamWriter sw = new StreamWriter($"D:/Visual/note.txt", true))
            {
                sw.WriteLine($"Info about properties and fields:");
                sw.WriteLine($"Properties:");
                foreach (MemberInfo mi in myType.GetProperties())
                {
                    sw.WriteLine($"{mi.Name} : {mi.MemberType}");
                }
                foreach (MemberInfo mi in myType.GetFields())
                {
                    sw.WriteLine($"Fields:");
                    sw.WriteLine($"{mi.Name} : {mi.MemberType}");
                }
                sw.WriteLine();
            }
        }
        public void GetInterfaces(T obj)
        {
            Type myType = obj.GetType();

            using (StreamWriter sw = new StreamWriter($"D:/Visual/note.txt", true))
            {
                sw.WriteLine($"Info about implemented interfaces:");
                foreach (MemberInfo mi in myType.GetInterfaces())
                {
                    sw.WriteLine($"{mi.Name}");
                }
                sw.WriteLine();
            }
        }
        public void GetUserMethod(T obj)
        {
            Console.Write($"Enter name of method to find: ");
            var nameOfMethod = Console.ReadLine();
            Type myType = obj.GetType();
            MethodInfo methodInfo = myType.GetMethod(nameOfMethod);
            ParameterInfo[] myParameter = methodInfo.GetParameters();
            
            using (StreamWriter sw = new StreamWriter($"D:/Visual/note.txt", true))
            {
                sw.WriteLine($"Info about user methods:");
                for (int i = 0; i < myParameter.Length; i++)
                {
                    sw.WriteLine($"{myParameter[i]}");
                }
            }
        }
        public void CallAnyMethod(T obj)
        {
            Type myType = obj.GetType();
            ConstructorInfo constructorInfo = myType.GetConstructor(Type.EmptyTypes);
            object objType = constructorInfo.Invoke(new object[] { });

            MethodInfo methodInfo = myType.GetMethod("Method1");
            object methodObj = methodInfo.Invoke(objType, new object[] { 2 });
            
        }
    }
}
