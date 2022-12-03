#include <stdio.h>
#include <windows.h>
#define _USE_MATH_DEFINES
#include <math.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	double deg, rad;
	printf("кут в радіанах: ");
	scanf_s("%lf", &rad);
	deg = rad * (180.0 / M_PI);
	printf("Результат %f", deg);
	return 0;
}