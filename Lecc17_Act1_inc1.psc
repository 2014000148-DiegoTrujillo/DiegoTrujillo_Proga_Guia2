Algoritmo LECC17_ACT1_INC1
	Escribir "Nombre: Diego Trujillo"
	Escribir "Grado Y Seciion: IV C"
	Escribir "Clave: 31"
	Escribir "Ejemplo de la matriz"
	
	Definir dn Como Caracter
	Definir fl,cl Como Entero 
	Dimensionar dn[2,4]
	
	dn[1,1]="Chocolate"
	dn[1,2]="Fresa"
	dn[1,3]="Vainilla"
	dn[1,4]="Chicle"
	
	dn[2,1]="Caramelo"
	dn[2,2]="Cafe"
	dn[2,3]="Coco"
	dn[2,4]="Leche"
	
	Para fl=1 Hasta 2 Con Paso 1 Hacer
		Para cl=1 Hasta 4 Con Paso 1 Hacer
			Escribir Sin Saltar dn[fl,cl],"   |   "
		Fin Para
		Escribir ()
	Fin Para
FinAlgoritmo
