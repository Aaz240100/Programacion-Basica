#include <iostream>
using namespace std;
int main()
{
//Mensaje de Bienvenida
cout << "Practica 3, Unidad 2 - Aaron" << "\n";
//Se declaran los números que se sumaran (pueden ser decimales) 
float NOTA;
//Se pide el primer numero
cout << "Por favor ingrese la calificacion: ";
//Se asigna el primer valor a NOTA
cin >> NOTA;
if (NOTA>=3.0)
cout <<"Aprobado";
else
cout<<"Reprobado";
//Se muestra el resultado.
return 0;
}
