# Jorge Calzada Asenjo
# Challenge 471: Looking for the puncture
# Ruby 2.5.1 version

=begin
    If you put a wheel with a puncture in water, knowing the angle at
    which we put it and where the hole is, calculate where it would be
    better to turn or if it would not matter.
=end

=begin
    Example of input
    3
    90
    91
    0
    359
    0
    180


    Example of output
    ASCENDENTE
    DESCENDENTE
    DA IGUAL
=end

cases = gets.to_i

for i in 0...cases
    startingAngle = gets.to_i
    puncture = gets.to_i
    diff = startingAngle - puncture

    if (diff == 0 or diff == -180 or diff == 180)
        puts("DA IGUAL")
    elsif ((diff < 0 and diff > -180) or (diff > 180))
        puts("ASCENDENTE")
    else
        puts("DESCENDENTE")
    end
end
