(*
Challenge 1.06 - Counting in the sand (acepta 369)
Counting in base 1
*)
program Base1;

var
    i, n: integer;
    
begin
    readln(n);
    while (n <> 0) do
    begin
        for i:= 1 to n do
            write('1');
        writeln;
        readln(n);
    end;
end.
