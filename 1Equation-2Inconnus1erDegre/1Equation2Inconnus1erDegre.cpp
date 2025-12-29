// 2Equation2Inconnus1erDegreProgram.cpp : Defines the entry point for the console application.
//

#pragma once

#ifndef WINVER 
#define WINVER 0x0600
#endif
#ifndef _WIN32_WINNT
#define _WIN32_WINNT 0x0600 
#endif
#ifndef _WIN32_WINDOWS  
#define _WIN32_WINDOWS 0x0410
#endif
#ifndef _WIN32_IE 
#define _WIN32_IE 0x0700
#endif
#ifndef VC_EXTRALEAN
#define VC_EXTRALEAN    
#endif

#include <stdio.h>
#include <tchar.h>
#include <Windows.h>
#include <math.h>
#include <iostream>
#include "resource.h"
#pragma warning(disable:4244)//Perte de donnees en convertion
using namespace std;

#define Lit cin
#define Ecrit cout;
#define Fin endl;

HINSTANCE hCons;

void Resoudre(int x,int y,int z);

int main(int argc, TCHAR* argv[], TCHAR* envp[])
{
	int nRetCode = 0;
	int x, y, z;

	hCons=GetModuleHandle( 0x00);
	if(!hCons){

		printf("Fatal Error: HMODULE initialization failed\n");
		nRetCode = 1;
	}
	else
	{
		SetConsoleTitle("Logiciel de resolution 2 equations 2 inconnus 1er degre");
        printf("Hello Equation2Inconnus1erDegre!          Créé par Patrice Waechter-Ebling 2022      v:1.0.0.a  V:C++\n Version réduite aux entiers uniquement");
       // Console.ForegroundColor = ConsoleColor.Blue;
		printf("\nEntrez le nombre de X: ");Lit>>x;
		printf("Entrez le nombre de Y: ");Lit>>y;
		printf("Entrez le nombre de la constante: ");Lit>>z;
        Resoudre(x,y,z);
    //    Console.ForegroundColor = ConsoleColor.White;
		printf("\n Appuyez entree pour quitter ");nRetCode=Lit.get();
	}

	return nRetCode;
}
void Resoudre(int x,int y,int z) {
    double a = z/y;
    double b = y / x;
    double c = z / x;
    int e = 0;
    printf("Formulation: %dx+%dy=%d\n", x, y, z);
    cout << "\nDelimitation:X=0 Y=" << a << "\t[0, " << a << "]" << Fin;
    cout << "Delimitation:Y=0 X=" << c << "\t[" << c << ", 0]\n" << Fin;
    for (int i = 0; i < a; i++) {

        if (y < 0) {
            for (int j = 0; j < c; j--) {
                if (x * i + y * j == z) {
                    cout<< "Solution " << ++e << ": x=" << i << ": y=" << j << " => " << (x * i) << "+" << (y * j) << "=" << (x * i + y * j) << Fin;
                }
            }
        }
        else {
            for (int j = 0; j < c; j++) {
                if (x * i + y * j == z) {
                    cout << "Solution " << ++e << ": x=" << i << ": y=" << j << " => " << (x * i) << "+" << (y * j) << "=" << (x * i + y * j) << Fin;
                }
            }

        }
    }
 /*   printf("Etape %d: %dx-%d=%dy\n", e++, x, z, y);
    printf("Etape %d: %dx-%dy-%d=0\n",e++,x,y,z);
    printf("Etape %d: %dx+%dy=%d\n",e++,b,c );
    printf("Etape %d: %dx+%dy-%d=0\n",e++,b, c);
    printf("Etape %d: %dx+%dy-%d=%dx+%dy-%d\n" , e++, x, y, c,x1,y1, z1 );
    printf("Etape %d: %dx+%dy-%d=0\n" , e++, (x - x1), (y - y1),(z - z1));
    printf("Etape %d: Y=%dx-%dy-%d=%d\n" , e++, y - y1, z - z1 , x - x1, ((z - z1) - (y - y1)) / (x - x1) );
    if (((y - y1) - (z - z1)) / (x - x1) < 0)  {
        printf("Etape %d :Y=",e++,(((y - y1) - (z - z1)) / (x - x1) * (-1)));
    }
    float y2 = abs(((((y - y1) - (z - z1)) / (x - x1) * (-1))));
   // Console.ForegroundColor = ConsoleColor.Yellow;
    printf("Etape %d :Y=%f", e++,y2 );
    printf("Etape %d :X=(%d-%d*%d)/%d=%f",e++,z,y2,y,x,(z - y2 * y) / x );
    printf("Etape %d :X=%f",e++,(z - y2 * y) / x );
    for (int a = 1; a <= abs(c); a++)
    {
        for (int d = 1; d <= abs(c); d++)
        {
            if ((a * x + d * y) == z)
            {
                if ((x1 * a) + (y1 * d) == z1)
                {
//                    Console.ForegroundColor = ConsoleColor.Magenta;
                    printf("\n\nSolution:  x=%d; y=%d\n",a,d);
 //                   Console.ForegroundColor = ConsoleColor.White;

                }
            }
        }
    }
            //Console.BackgroundColor = ConsoleColor.Black;
	printf("\nEtape %d:test f(%f): %d*%d+%d*%d=%f+%d" ,e++,(z - y2 * y) / x,(z - y2 * y) / x,x,y2,y,(z - y2 * y) / x * x,y2 * y );
            if ((z - y2 * y) / x * x + y2 * y == z)
            {
      //          Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
      //          Console.ForegroundColor = ConsoleColor.Red;
            }
            printf(" (z - y2 * y) / x * x + y2 * y");
      //      Console.ForegroundColor = ConsoleColor.White;

			printf("Etape %d: test f'(%f):%d*%d+%d*%d=%f",e,z - (y2 * y) / x,(z - y2 * y) / x,x1,y2,y1,(z - y2 * y) * x1 / x,y1 * y2);
            if ((x1 * (z - y2 * y) / x + y1 * y2) == z1)
            {
     //           Console.ForegroundColor = ConsoleColor.Green;
            }
            else {
        //        Console.ForegroundColor = ConsoleColor.Red;
            }
            printf("%f", x1 * (z - y2 * y) / x + y1 *y2);

     //       Console.ForegroundColor = ConsoleColor.White;
     */
}
