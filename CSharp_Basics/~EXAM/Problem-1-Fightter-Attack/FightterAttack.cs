using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Fightter_Attack
{
    class FightterAttack
    {
        static void Main(string[] args)
        {
            int pFirstX = int.Parse(Console.ReadLine());
            int pFirstY = int.Parse(Console.ReadLine());
            int pSecondX = int.Parse(Console.ReadLine());
            int pSecondY = int.Parse(Console.ReadLine());
            int fighterX = int.Parse(Console.ReadLine());
            int fighterY = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int directHitX = fighterX + d;
            int directHitY = fighterY;

            int hit75PercentX;
            int hit75PercentY = fighterY;
            //if (d > 0)
            //{
            //    hit75PercentX = directHitX + 1;
            //}
            //else
            //{
            //    hit75PercentX = directHitX - 1;
            //}

            int hitUpperX = directHitX,
                hitUpperY = directHitY + 1,
                hitLowerX = directHitX,
                hitLowerY = directHitY - 1;

            int pUpper = Math.Max(pFirstY, pSecondY),
                pLower = Math.Min(pFirstY, pSecondY),
                pLeft = Math.Min(pFirstX, pSecondX),
                pRight = Math.Max(pFirstX, pSecondX);


            int sum = 0;

            int currentCheckX = directHitX;
            int currentCheckY = directHitY;
            int currentDamage = 100;

            if (currentCheckY >= pLower && currentCheckY <= pUpper)
            {
                if (currentCheckX >= pLeft&& currentCheckX <= pRight)
                {
                    sum += currentDamage;
                }
            }
            
            currentCheckX = hit75PercentX;
            currentCheckY = hit75PercentY;
            currentDamage = 75;

            if (currentCheckY >= pLower && currentCheckY <= pUpper)
            {
                if (currentCheckX >= pLeft && currentCheckX <= pRight)
                {
                    sum += currentDamage;
                }
            }

            currentCheckX = hitUpperX;
            currentCheckY = hitUpperY;
            currentDamage = 50;

            if (currentCheckY >= pLower && currentCheckY <= pUpper)
            {
                if (currentCheckX >= pLeft && currentCheckX <= pRight)
                {
                    sum += currentDamage;
                }
            }
            
            currentCheckX = hitLowerX;
            currentCheckY = hitLowerY;
            currentDamage = 50;

            if (currentCheckY >= pLower && currentCheckY <= pUpper)
            {
                if (currentCheckX >= pLeft && currentCheckX <= pRight)
                {
                    sum += currentDamage;
                }
            }

            Console.WriteLine(sum + "%");

        }
    }
}
