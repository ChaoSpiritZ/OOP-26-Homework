using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_26_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string codeWord = "peanut";
            MyProtectedUniqueList pList = new MyProtectedUniqueList(codeWord);
            pList.Add("shame");
            pList.Add("cat");
            pList.Add("door");
            pList.Add("mystic");
            Console.WriteLine(pList);
            string existingWord = "door";
            string toBeRemovedWord = "piano";
            int toBeRemovedIndex = 4;
            string wrongWord = "elephant";
            try
            {
                //pList.Add(null);
                //pList.Add("");
                //pList.Add(existingWord);
                //pList.Remove(toBeRemovedWord);
                //pList.RemoveAt(toBeRemovedIndex);
                pList.Clear(wrongWord);
            }
            catch (ArgumentNullException anex)
            {
                //Console.WriteLine(anex.Message);
                Console.WriteLine("You can only input words that actually have characters!");
            }
            catch (ArgumentOutOfRangeException aoorex)
            {
                Console.WriteLine($"Removing failed! index [{toBeRemovedIndex}] is not within the list's bounds (0 - {pList.ListCount() - 1})");
            }
            catch (ArgumentException aex)
            {
                //Console.WriteLine(aex.Message);
                Console.WriteLine($"removing failed! {toBeRemovedWord} was not found on the list! ");
            }
            catch(InvalidOperationException ioex)
            {
                //Console.WriteLine(ioex.Message);
                Console.WriteLine($"The word '{existingWord}' already exists in the list!");
            }
            catch(AccessViolationException avex)
            {
                Console.WriteLine($"clearing failed! incorrect keycode! ({wrongWord})");
            }
        }
    }
}
