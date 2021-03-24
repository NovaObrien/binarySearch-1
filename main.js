// Let min = 1min=1m, i, n, equals, 1 and max = nmax=nm, a, x, equals, n.
// Guess the average of maxmaxm, a, x and minminm, i, n, rounded down so that it is an integer.
// If you guessed the number, stop. You found it!
// If the guess was too low, set minminm, i, n to be one larger than the guess.
// If the guess was too high, set maxmaxm, a, x to be one smaller than the guess.
// Go back to step two.
let min = 1;
let max = n;
let primes = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97];
