function getFibonator() {
    let previous = 0;
    let current = 0;

    function fibonacci() {
        if (previous == 0 && current == 0) {
            current = 1;
            return 1;
        }
        let sum = previous + current;
        previous = current;
        current = sum;
        return sum;
    }

    return fibonacci;
}

let fib = getFibonator();
console.log(fib()); // 1
console.log(fib()); // 1
console.log(fib()); // 2
console.log(fib()); // 3
console.log(fib()); // 5
console.log(fib()); // 8
console.log(fib()); // 13