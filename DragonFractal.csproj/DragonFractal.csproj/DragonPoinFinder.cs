// В цьому просторі імен містяться засоби для роботи із зображеннями. 
// Щоб він став доступним, в проект було подключено Reference на збірку System.Drawing.dll
using System.Drawing;
using System;
using System.Numerics;

namespace Fractals
{
	internal static class DragonPointFinder
	{
		private static DragonPoint dragonPoint = new DragonPoint();
		private static readonly RandomNumGenerator rNumGenerator = new RandomNumGenerator();

		public static void DragonFractalDrawer(Pixels pixels, int iterationsCount)
		{
			dragonPoint = new DragonPoint(1, 0);	

            for (int i = 0; i < iterationsCount; i++)
            {
				switch (rNumGenerator.NumGenerate(2))
                {
					case 0:
						PointModifier(0, 20);
						break;

					default:
						PointModifier(1, 115);
						break;
                } 
				//NonRandomPoint();

				pixels.SetPixel(dragonPoint);

			}

			#region Task
			/*
			Почніть з точки (1, 0)
			Створіть генератор рандомних чисел з сідом seed (
			 1. Створення нового генератора послідовності випадкових чисел: 
					var random = new Random(seed);
					seed — число, що повністю визначає послідовність псевдовипадкових чисел цього генератора.

			 2. Отримання чергового псевдовипадкового числа від 0 до 9:
					var nextNumber = random.Next(10);)

			На кожній ітерації:

			1. Виберіть випадково одне з наступних перетворень і застосуйте його до поточної точки :

				Перетворення 1. (поворот на 45° і стиснення в sqrt(2) раз):
				x' = (x · cos(45°) - y · sin(45°)) / sqrt(2)
				y' = (x · sin(45°) + y · cos(45°)) / sqrt(2)

				Перетворення 2. (поворот на 135°, стиснення в sqrt(2) раз, зсув по X на одиницю):
				x' = (x · cos(135°) - y · sin(135°)) / sqrt(2) + 1
				y' = (x · sin(135°) + y · cos(135°)) / sqrt(2)

			2. Намалюйте поточну точку методом pixels.SetPixel(x, y)*/
			#endregion

		}

		private static void PointModifier(byte isSlide, int angle) 
        {
			decimal compressionCoefficient = (decimal) Math.Sqrt(2);

			decimal xValue = (dragonPoint.xCoord * (decimal)Math.Cos(angle) - dragonPoint.yCoord * (decimal)Math.Sin(angle)) / compressionCoefficient + isSlide;
			decimal yValue = (dragonPoint.xCoord * (decimal)Math.Sin(angle) + dragonPoint.yCoord * (decimal)Math.Cos(angle)) / compressionCoefficient;

			dragonPoint = new DragonPoint(xValue, yValue);			
		}
	}
}