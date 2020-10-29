Program Pzim ;
var apA,apB,apC:string;
apostaA,apostaB,apostaC,coluna,linha,somaVermelho,somaAmarelo,somaVerde,somaAzul,somaBranco:integer;
cavaloVermelho,cavaloAmarelo,cavaloVerde,cavaloAzul,cavaloBranco,vermelhoVenceu,amarelovenceu,verdevenceu,azulvenceu,brancovenceu:integer;
Begin
    writeln(' Digite o nome do primeiro apostador: ');
    readln(apA);
    clrscr;
   	 repeat
		write('Digite a aposta entre 1 e 5 :');
		readln(apostaA);
		clrscr;
	   until (apostaA > 0) and (apostaA < 6);
	  
	  write('Digite o nome do segundo apostador: ');
	  readln(apB);
	   repeat
		write('Digite a aposta entre 1 e 5 :');
		readln(apostaB);
		clrscr;	
	   until (apostaB > 0) and (apostaB < 6) and (apostaB <> apostaA);
	
  	write('Digite o nome do terceiro apostador: ');
  	readln(apC);
  	 repeat
		write('Digite a aposta entre 1 e 5 :');
		readln(apostaC);
		clrscr;	
  	 until (apostaC > 0) and (apostaC < 6) and (apostaC <> apostaA) and (apostaC <> apostaB);
  	 
  	 clrscr;
  	 
 	for coluna:= 1 to 80 do
	  	begin
			gotoxy (coluna,1);
    	textcolor (white);
      write (#178);
      
      gotoxy (coluna,27);
    	textcolor (white);
      write (#178);
		  end;
		
	for linha:= 2 to 27 do
		  begin
			gotoxy (1,linha);
    	textcolor (white);
      write (#178);
      
      gotoxy (80,linha);
    	textcolor (white);
      write (#178);
		  end;
		  
		  
		  
		  gotoxy(2,5);
		  textcolor(red);
		  writeln(#219);
		  
		  gotoxy(2,10);
		  textcolor(yellow);
		  writeln(#219);
		  
		  gotoxy(2,15);
		  textcolor(green);
		  writeln(#219);
		  
		  gotoxy(2,20);
		  textcolor(blue);
		  writeln(#219);
		  
		  gotoxy(2,25);
		  textcolor(white);
		  writeln(#219);
		  
		  somaVermelho:= 2;
	    somaAmarelo:= 2;
	    somaVerde:= 2;
	    somaAzul:= 2;
	    somaBranco:= 2;
	    
	  repeat
		randomize;
		cavaloVermelho:= random(2);
		cavaloAmarelo:= random(2);
		cavaloVerde:= random(2);
		cavaloAzul:= random(2);
		cavaloBranco:= random(2); 
		
		somaVermelho:= somaVermelho + cavaloVermelho;
		somaAmarelo:= somaAmarelo + cavaloAmarelo;
		somaVerde:= somaVerde + cavaloVerde;
		somaAzul:= somaAzul + cavaloAzul;
		somaBranco:= somaBranco + cavaloBranco;
		
		
		gotoxy (somaVermelho,5);
		textcolor (red);
		write('1-');
	  write (#219);  
		
		gotoxy (somaAmarelo,10);
		textcolor (yellow);
		write('2-');
	  write (#219);
		
		gotoxy (somaVerde,15);
		textcolor (green);
		write('3-');
	  write (#219);
		
		gotoxy (somaAzul,20);
		textcolor (lightblue);
		write('4-');
	  write (#219);
		
		gotoxy (somaBranco,25);
		textcolor (white);
		write('5-');
	  write (#219);
		
		delay(100);
		
		gotoxy (2,5);
		textcolor (black);
	  write (#219);  
		
		gotoxy (2,10);
		textcolor (black);
	  write (#219);
		
		gotoxy (2,15);
		textcolor (black);
	  write (#219);
		
		gotoxy (2,20);
		textcolor (black);
	  write (#219);
		
		gotoxy (2,25);
		textcolor (black);
	  write (#219);
		
		
				
		gotoxy (somaVermelho,5);
		textcolor (black);
	  write (#219);  
		
		gotoxy (somaAmarelo,10);
		textcolor (black);
	  write (#219);
		
		gotoxy (somaVerde,15);
		textcolor (black);
	  write (#219);
		
		gotoxy (somaAzul,20);
		textcolor (black);
	  write (#219);
		
		gotoxy (somaBranco,25);
		textcolor (black);
	  write (#219);
		
		until (somaAzul >= 80) or (somaVermelho >= 80) or (somaAmarelo >= 80) or (somaVerde >= 80) or (somaBranco >= 80);
		
		
		
		
 clrscr;
	textcolor(white);
	
	vermelhovenceu:= 0; 
	amarelovenceu:= 0; 
	verdevenceu:= 0; 
	azulvenceu:= 0; 
	brancovenceu:= 0;
	
	if somaVermelho >= 80 then
		begin
			vermelhovenceu:= 1;
			write('O ');
			textcolor(red);
			write('CAVALO VERMELHO ');
			textcolor(white);
			writeln(' é o vencedor!');	
		end
	else
		if somaAmarelo >= 80 then
			begin
				amarelovenceu:= 2;
				write('O ');
				textcolor(yellow); 
				write('CAVALO AMARELO ');
				textcolor(white);
				writeln('é o vencedor!');
			end
		else
			if somaVerde >= 80 then
				begin
					verdevenceu:= 3;
					write('O ');
					textcolor(green);
					write('CAVALO VERDE ');
					textcolor(white);
					writeln('é o vencedor!');
				end
			else
				if somaAzul >= 80 then
					begin
						azulvenceu:= 4;
						write('O ');
						textcolor(blue);
						write('CAVALO AZUL ');
						textcolor(white);
						writeln('é o vencedor!');
					end
				else
					begin
						brancovenceu:= 5;
						write('O ');
						textcolor(white);
						write('CAVALO Branco ');
						writeln('é o vencedor!');
					end;
					
					if apostaA = vermelhovenceu then
		begin
			textcolor(green);
			writeln('O apostador ', apA, ' venceu!');
			writeln;
	  end
	else
		if apostaA = amarelovenceu then
			begin                                         
				textcolor(green);
				writeln('O apostador ', apA, ' venceu!');
			  writeln;
			end
		else
			if apostaA = verdevenceu then
				begin
					textcolor(green);
					writeln('O apostador ', apA, ' venceu!');
					writeln;
				end
			else
				if apostaA = azulvenceu then
					begin
						textcolor(green);
						writeln('O apostador ', apA, ' venceu!');
						writeln;
					end
				else
					if apostaA = brancovenceu then
						begin
							textcolor(green);
							writeln('O apostador ', apA, ' venceu!');
							writeln;
						end
					else
						begin
							textcolor(red);
							writeln('O apostador ', apA, ' perdeu!');
							writeln;
						end;
						
	//verificando apostador B				
	if apostaB = vermelhovenceu then
		begin
			textcolor(green);
			writeln('O apostador ', apB, ' venceu!');
			writeln;
		end
	else
		if apostaB = amarelovenceu then
			begin
				textcolor(green);
				writeln('Apostador ', apB, ' venceu!');
				writeln;
			end
		else
			if apostaB = verdevenceu then
				begin
					textcolor(green);
					writeln('Apostador ', apB, ' venceu!');
					writeln;
				end
			else
				if apostaB = azulvenceu then
					begin
						textcolor(green);
						writeln('O apostador ', apB, ' venceu!');
						writeln;
					end
				else
					if apostaB = brancovenceu then
						begin
							textcolor(green);
							writeln('O apostador ', apB, ' venceu!');
							writeln;
						end
					else
						begin
							textcolor(red);
							writeln('O apostador ', apB, ' perdeu!');
							writeln;
						end;
						
	//verificando apostador C				
	if apostaC = vermelhovenceu then
		begin
			textcolor(green);
			writeln('O apostador ', apC, ' venceu!');
			writeln;
		end
	else
		if apostaC = amarelovenceu then
			begin
				textcolor(green);
				writeln('O apostador ', apC, ' venceu!');
				writeln;
			end
		else
			if apostaC = verdevenceu then
				begin
					textcolor(green);
					writeln('O apostador ', apC, ' venceu!');
					writeln;
				end
			else
				if apostaC = azulvenceu then
					begin
						textcolor(green);
						writeln('O apostador: ', apC, ' venceu!');
						writeln;
					end
				else
					if apostaC = brancovenceu then
						begin
							textcolor(green);
							writeln('O apostador ', apC, ' venceu!');
							writeln;
						end
					else
						begin
							textcolor(red);
							writeln('O apostador ', apC, ' perdeu!');
							writeln;
						end;
End.
