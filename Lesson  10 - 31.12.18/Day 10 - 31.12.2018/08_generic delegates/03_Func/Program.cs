﻿//------------------------------Func-----------------------------
//יש להעביר פרמטרים מופרדים בפסיק -  17 - 1 פרמטרים
//the type of the parameter is in the <>
//הפרמטר האחרון מהרשימה הוא זה שיקבע את סוג הערך המוחזר
//כל השאר קובעים פרמטרים שהפונקציה מקבלת
//----------
//חובה להעביר את סוג הטיפוס המוחזר - אולם לא חובה לקבל פרמטרים לפונקציה שניצור\

using System;

namespace _03_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //פונקציה שלא מקבלת פרמטרים ומחזירה מספר
            Func<int> f1 = () => { return 6; };  

            //פונקציה שמקבלת שני מספרים ומחזירה האם הם שווים
            Func<int, int, bool> f2 = (n1, n2) => {              
                return n1==n2;
            };

            Console.WriteLine(f1());
            Console.WriteLine(f2(1,3));

        }
    }
}


/*
 
     OUTPUT:
     ____________________
     
     6
     False
*/
