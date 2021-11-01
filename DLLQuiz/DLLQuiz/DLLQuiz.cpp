// DLLQuiz.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#define EXPORT_API __declspec(dllexport)
#include <iostream>
#include<random>

extern "C"
{
	//from: https://www.daniweb.com/programming/software-development/tutorials/1769/c-random-numbers
	int  EXPORT_API RandNum() {
		srand((unsigned)time(0)); 
		int  randx =  (rand() %  3+ 1);
		return randx;
	}
}
int main() {
	std::cout << RandNum();
	/*int  randx = 1 + (rand() % 10 + 3);
	std::cout << randx;*/
}