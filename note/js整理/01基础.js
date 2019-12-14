console.log('---------------js的数据类型----概念篇---------------');
/* 
  *******js的数据类型----概念篇*******
*/

/* 
  原始数据类型:
    symbol
    bigint：目的是比Number数据类型支持范围更大的整数值。【提案中】
*/
console.log('------------原始数据类型------------');

const data = ["String", "Number", "Boolean", "null", "undefined", "symbol", 'bigint']

/* 
  引用数据类型
    普通对象:Object,
    数组对象:Array,
    正则对象:RegExp,
    日期对象:Date,
    数学函数:Math,
    函数对象:Funtion,
*/
const obj = ["Object", "Array", "RegExp", "Date", "Math", "Funtion"]


console.log('------------对象引用问题------------');
/* 
  ****对象引用问题**** 
*/

function text(person) {
  person.age = 20;
  person = {
    name: "xiaoming",
    age: 10
  }
  return person
}
const p1 = {
  name: "xiaohong",
  age: 100
}
const p2 = text(p1);
console.log(p1);//{name:xiaohong,age:20}
console.log(p2);//{name:xiaoming,age:10}
/*
  上面函数分析
  在调用text函数时，我们传入的实参p1，其实是将p1对象的引用地址传入。故第一个语句改变的是p1对象内的age值。
  后续我们将person变量又重新复制了新对象，故此时我们修改了引用地址，解除了和p1的联系，并于新对象关联。
*/


console.log('------------null的相关问题------------');
/* 
  ****null的相关问题****
*/

/* 
  null不是对象。typeof会判断为对象，这是个bug。
  原因:在js最初的版本中使用的是32位的系统，为了性能考虑使用低位存储变量的类型信息，000开头代表对象。
       然而null则为全零，所以错误判断为object。
*/
console.log(typeof null);//object

console.log('------------"1".toString()可以调用------------');

/* ****'1'.toString()可以调用**** */

var s = new Object('1');//不建议使用new来创建string,number,boolean
console.log(s);
console.log(typeof s);//object
console.log(typeof s.toString());//string
s = null

console.log('------------0.1+0.2!==0.3------------');

/* ****0.1+0.2!==0.3**** */
console.log(0.1 + 0.2 === 0.3);//false
/*
  0.1和0.2在转换成二进制时，会无限循环，由于标准位数后面多余被截掉，导致精度不足；
  故在转换成十进制时就会变成0.30000000000004
*/

console.log('---------------js的数据类型----检测篇---------------');
/*
  *******js的数据类型----检测篇*******
*/



console.log('------------typeof判断------------');

/* ****typeof判断**** */

//基本类型
console.log(typeof "1");//string
console.log(typeof 1);//number
console.log(typeof true);//boolean
console.log(typeof Symbol());//symbol
//引用类型:除了函数为function,其余都显示object
console.log(typeof {});//object
console.log(typeof []);//object
console.log(typeof console.log);//Function
/* 因此使用typeof适合判断基本类型 */

console.log('------------instanceof判断------------');

/* ****instanceof判断**** */

//instanceof判断是基于原型链的查询，只要处于原型链中，返回true
const Person = function () { }
const p11 = new Person()
console.log(p11 instanceof Person);//true
const str1 = "hello";
const str2 = new String("hello");
console.log(str1 instanceof String);//false
console.log(str2 instanceof String);//true


console.log('------------instanceof能否判断基本数据类型------------');

/* ****instanceof能否判断基本数据类型**** */

class PrimitiveNumber {
  static [Symbol.hasInstance](x) {
    return typeof x === 'number'
  }
}
console.log(111 instanceof PrimitiveNumber);//true
/* 其实就是自定义instansceof行为的一种方式。将原有的instanceof方法重定义，换成typeof判断 */


console.log('------------手动实现instanceof------------');
/* ****手动实现instanceof**** */

function myInstanceof(left, right) {
  //基本数据类型直接返回false
  if (typeof left !== Object || left !== null) return false;
  const proto = Object.getPrototypeOf(left)
  while (true) {
    //查找到尽头没找到返回false
    if (proto === null) return false;
    //查找到proto(left的原型)和right的原型相同，返回true
    if (proto == right.prototype) return true;
    //继续获取proto的原型
    proto = Object.getPrototypeOf(proto)
  }
}
console.log(myInstanceof('111', String));//false
console.log(myInstanceof(new String("111"), String));//true

console.log('------------Object.is和===区别------------');

/* ****Object.is和===区别**** */

//具体来说就是+0、-0、NAN
function is(x, y) {
  if (x === y) {
    //运行到1/x===1/y的时候x、y都为0，但是1/-0=-Infinity,1/0=Infinity,是不一样的。
    return x !== 0 || y !== 0 || 1 / x === 1 / y
  } else {
    //NAN===NAN为false，这是不对的，所以我们在这里做个拦截，x!==x时那么一定是NAN，同理y。
    return x !== x && y !== y
  }
}

console.log('------------js数据类型---转换篇------------');

/* *******js数据类型---转换篇******* */

/* ****[]==![]结果**** */
/*
  ==，指左右两边先转换成数值，然后进行比较。
  []转换为数值是0
  ![]先转换为布尔值true，取反为false，false转换成数值0
  []==![] 结果true
*/

console.log('------------==和===区别------------');

/* ****==和===区别**** */

/*
  ===为严格相等，指左右两边，不止数值相等，数据类型也要一样。
  ==不是很严格，指左右两边，只要数值相等，就返回true。涉及一些转换
*/
/*
  ==的转换规则：
    1.两边类型相同比较值的大小。
    2.判断类型是否为null和undefined，是的话返回true
    3.判断的类型是否是string和number，是的话将string转换成number，在比较。
    4.判断其中一方是否是boolean，是的话就把boolean转换成number，在比较。
    5.如果其中一方是object，另一方为string，number，boolean，则将object转换为string，在比较。
*/
console.log({ a: 1 } == true);//false
console.log({ a: 1 } == "[object Object]");//true

console.log('------------对象转原始类型的流程------------');

/* ****对象转原始类型的流程**** */

/*
  1.如果存在symbol的toprimitive，则第一调用
  2.如果存在valueOf(),则第二调用
  3.如果存在toString(),则第三调用
  如果自己没有设置，则在原型链中也会存在。就是默认的转类型的形式。
*/
var obj1 = {
  value: 3,
  toString() {
    return 4
  },
  valueOf() {
    return 5
  },
  [Symbol.toPrimitive]() {
    return 6
  }
}
console.log(obj1 + 1);//7

console.log('------------如何让if(a==1&&a==2)成立------------');

/* ****如何让if(a==1&&a==2)成立**** */

var a = {
  value: 0,
  valueOf() {
    this.value++
    return this.value
  }
}
console.log(a == 1 && a == 2);//true
/* 其实就是上一个问题的应用
   当a==1时，转格式，调用了valueOf，value为1
   当a==2时，再次转格式，调用了valueOf，value为2
*/


console.log('------------闭包的概念--理解------------');

/* *******闭包的概念--理解******* */

/*
  闭包定义：有权访问另外一个函数内部变量的函数。
  产生原因：ES5中存在两种作用域——全局作用域和函数作用域
    当你在某一个作用域下去访问变量时，解释器首先会在当前作用域下查找，
    如果没有找到，就去父作用域找，直到找到该变量的标识符。若到达了作用域顶端仍旧没有找到，则会报错。
  作用域查找：从自身开始，直到找到全局作用域window为止。
*/
var a = 1;
function f1() {//f1的作用域为本身和window
  var a = 2
  function f2() {//f2的作用域为本身=>f1=>window
    var a = 3;
    console.log(a)
  }
  return f2
}
var x = f1()
x()
//闭包产生本质是：当前作用域中，存在指向负作用域的引用。

console.log('------------闭包的表现形式------------');

/* ****闭包的表现形式**** */
/* 
  1.返回一个函数。
  2.作为函数参数传递
  3.定时器,ajax请求,事件监听,跨窗口通信,web workers或者任何异步中,使用了回调函数,实际就是使用闭包。
*/
//2.作为函数参数传递
var a = 1;
function f11() {
  var a = 2;
  function f2() {
    console.log(a);
  }
  bar(f2)
}
function bar(fn) {
  //这就是闭包
  fn()
}
f11();//2
//3.定时器
setTimeout(function () {
  console.log("123");
}, 500)
document.getElementById("app").addEventListener("click", function () {
  console.log("click");
})
//4.IIFE立即执行函数。
var d = 'IIFE立即执行函数';
(function IIFE() {
  console.log(d);
})()


console.log('------------循环输出问题------------');

/* ****循环输出问题**** */

for (var i = 1; i <= 5; i++) {
  setTimeout(() => {
    console.log(i);
  }, 500)
}//输出全是6
console.log("i=", i);//6

/* 
  原因：因为setTimeout为宏任务,由于js中是单线程eventLoop机制，在主线程同步任务执行完后才会执行异步的setTimeout。
        在输出i的时候，当前作用域中已经不存在i，在向上一级寻找，找到了i，此时循环已经结束，i在全局中固定在了6，因此全为6;
*/
//解决办法
//1.IIFE(立即执行函数表达式)，当每次for循环时，把此时的i变量传递进去
console.log("IIFE(立即执行函数表达式)");
for (var i = 1; i <= 5; i++) {
  //传入的i为此时闭包的值
  (function (i) {
    setTimeout(() => {
      console.log(i);
    }, 500)
  })(i)
}
//2.给定时器传入第三个参数，作为第一个回调函数的参数
for (var i = 1; i <= 5; i++) {
  setTimeout((j) => {
    console.log(j);
  }, 500, i)
}
//3.使用es6中的let块作用域
for (let i = 1; i <= 5; i++) {
  setTimeout(() => {
    console.log(i);
  }, 500)
}


console.log('------------原型链--理解------------');

/* *******原型链--理解******* */


/* ****原型对象和构造函数关系**** */

/* 在js中每当定义一个函数数据类型(普通函数或类)的时候，都会自带一个prototype属性，这个属性指向函数的原型对象 */
/* 当函数经过new调用时,这个函数会成为构造函数，返回一个全新的实例对象，实例对象会含有__proto__属性，指向构造函数的原型对象 */

//实力对象=================  ============================================null
// ↑↑                     ↓↓                                            ↑↑
// ↑↑ (new)               ↓↓ (__proto__)                                ↑↑(__proto__)
// ↑↑                     ↓↓                                            ↑↑
// 构造函数==prototype==》原型对象==(__proto__)==》父级原型对象==...==》Object.prototype

/* 对象的hasOwnProperty()来检查对象自身中是否含有该属性 */
/* 使用in来检查对象中是否存在该属性，原型链中存在也会返回true */

console.log('------------js如何实现继承------------');
/* ****js如何实现继承**** */
//1.借助call，apply。问题是虽然能够拿到父类的数据，但是无法使用父类的函数方法。
function Student() {
  this.name = "xiaohong"
};
function Children() {
  Student.call(this);//===this.name="xiaohong"
  this.type = "children"
}
var children = new Children()
console.log(children.name);

//2.借助原型链的功能。存在不足，对Children2中的Student2修改，则另一个会同步，因为此处只存在一个Student2实例。
function Student2() {
  this.name = "小明";
}
function Children2() {
  this.type = "Children2"
}
Children2.prototype = new Student2
var child2 = new Children2()
// console.log(child2);



//3.组合继承优化
function Student3() {
  this.name = "小明3";
}
function Children3() {
  Children3.call(this)
  this.type = "Children3"
}
Student3.prototype = Children3.prototype
const student = new Student3()
console.log(student.type);

//组合继承最优质的方案----寄生组合继承
function Parents4() {
  this.name = "123"
}
function Children4() {
  Parents4.call(this)
  this.age = "123"
}
Children4.prototype = Object.create(Parents4.prototype)
Children4.prototype.construtor = Children4

/* ****设计思想谈谈继承的本身问题**** */
/* ******** */
/* ******** */
/* ******** */
/* ******** */
/* ******** */
/* ******** */
/* ******** */
/* ******** */
/* ******** */
/* ******** */
/* ******** */
/* ******** */











