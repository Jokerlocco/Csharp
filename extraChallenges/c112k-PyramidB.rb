# Jorge Calzada Asenjo
# Challenge 1.12: Pyramid of marbles
# Ruby 2.5.1 version

=begin
    To calculate how many marbles form a pyramid with triangular base knowing
    the height of the pyramid.
=end

=begin
    Example of input
    4
    1
    2
    3
    4


    Example of output
    1
    4
    10
    20
=end

cases = gets.to_i

cases.times do
    height = gets.to_i

    totalPyramid = (height * (height + 1) * (height + 2)) / 6

    puts totalPyramid
end
