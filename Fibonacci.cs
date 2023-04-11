let count = 0;

function fib(n) {
  count++;
  if(n <= 1) return n;
  return fib(n-1) + fib(n-2);
}

function memoization(fn) {
  let cache = {};
  return (...args) => {
    let key = args.join(',');
    if(key in cache) {
      return cache[key];
    } 
    
    cache[key] = fn.apply(null, args);
    return cache[key];
  }
}

let count = 0;
const fib = memoization((n) => {
  count++;
  if(n <= 1) return n;
  return fib(n-1) + fib(n-2);
})