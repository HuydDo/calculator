//dangerous identifier can be difference name

import sum2, { difference as subtract, product, quotient} from './functions.js'
const x = 10
const y = 5

document.getElementById('x').textContent = x
document.getElementById('y').textContent = y

document.getElementById('addition').textContent = sum2(x, y)
document.getElementById('subtraction').textContent = subtract(x, y)
document.getElementById('multiplication').textContent = product(x, y)
document.getElementById('division').textContent = quotient(x, y)
