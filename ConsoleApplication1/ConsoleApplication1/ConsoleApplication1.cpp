// ConsoleApplication1.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include "stdlib.h"
#include <stdio.h>

// 使用异或运算符
int FindRepeat(int array[], int length)
{

	int result = 0;

	for (int i = 1; i <= 1000; i++)

		result ^= i;

	for (int i = 0; i <= 1000; i++)

		result ^= array[i];

	return result;

}


int _tmain(int argc, _TCHAR* argv[])
{
	//printf("hello world");

	int a[1001];
	for (auto j = 0; j < 1001; j++)
		a[j] = j + 1;

	/*int i;
	for (i = 0; i < 1001; i++) {
	a[1000] += a[i];
	}

	printf("%d \n", a[1000]);

	a[1000] -= ((1001 * 1000) / 2);

	printf("%d \n", a[1000]);*/




	int x = FindRepeat(a, 1001);
	printf("%d", x);
	scanf_s("%d", &x);

	//printf("%d",x);

	//system("pause");
	return 0;
}

int Find(int *a)
{
	int i;
	for (i = 0; i <= 1000; i++)
	{
		a[1000] += a[i];
	}
	a[1000] -= (i * (i - 1)) / 2; //i的值为1001
	return a[1000];
}

