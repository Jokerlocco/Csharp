# Jorge Calzada Asenjo
# Challenge 1.10: Gregory XIII
# Ruby 2.5.1 version

=begin
    Calculate how many days you have in February in a given year
=end

=begin

Example of input
4
1584
1600
1699
1700


Example of output
29
29
28
28
    
=end

cases = gets.to_i

cases.times do
    year = gets.to_i

    # solution 1: using conditional if
    if year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)
        puts 29
    else
        puts 28
    end

    # solution 2: using conditional ternary
    # numberOfDays = (year % 4 == 0 && (year % 100 != 0 ||
    #     year % 400 == 0)) ? 29 : 28
    # puts numberOfDays
end
