Program Pzim ;

var
i:integer;
Begin
    for i:=1  to 1000 do
    begin
      textbackground(i);
      clrscr;        
      gotoxy(50,20);
      writeln('TEXTO');
      delay(1);
    end;
    
End.