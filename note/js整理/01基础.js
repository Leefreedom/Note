/* 
  *******js的数据类型----概念篇*******
*/
/* 
  原始数据类型:
    symbol
    bigint：目的是比Number数据类型支持范围更大的整数值。【提案中】
*/
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

/* 
  ****null的相关问题****
*/
/* 
  null不是对象。typeof会判断为对象，这是个bug。
  原因:在js最初的版本中使用的是32位的系统，为了性能考虑使用低位存储变量的类型信息，000开头代表对象。
       然而null则为全零，所以错误判断为object。
*/
console.log(typeof null);//object

/* ****'1'.toString()可以调用**** */
const s = new Object('1');//不建议使用new来创建string,number,boolean
s.toString()
s = null
/* ****0.1+0.2!==0.3**** */
/*
  0.1和0.2在转换成二进制时，会无限循环，由于标准位数后面多余被截掉，导致精度不足；
  故在转换成十进制时就会变成0.30000000000004
*/


/*
  *******js的数据类型----检测篇*******
*/

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

/* ****instanceof判断**** */
//instanceof判断是基于原型链的查询，只要处于原型链中，返回true
const Person = function () { }
const p1 = new Person()
console.log(p1 instanceof Person);//true
const str1 = "hello";
const str2 = new String("hello");
console.log(str1 instanceof String);//false
console.log(str2 instanceof String);//true

/* ****instanceof能否判断基本数据类型**** */
class PrimitiveNumber {
  static [Symbol.hasInstance](x) {
    return typeof x === 'number'
  }
}
console.log(111 instanceof PrimitiveNumber);//true

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
/* *******js数据类型---转换篇******* */

/* ****[]==![]结果**** */
/*
  ==，指左右两边先转换成数值，然后进行比较。
  []转换为数值是0
  ![]先转换为布尔值true，取反为false，false转换成数值0
  []==![] 结果true
*/

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
console.log({ a: 1 } == "[object object]");//true

/* ****对象转原始类型的流程**** */
/*
  1.如果存在symbol的toprimitive，则第一调用
  2.如果存在valueOf(),则第二调用
  3.如果存在toString(),则第三调用
*/
var obj = {
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
console.log(obj + 1);//7

/* ****如何让if(a==1&&a==2)成立**** */
var a = {
  value: 0,
  valueOf() {
    this.value++
    return this.value
  }
}
console.log(a == 1 && a == 2);//true

/* *******闭包的概念--理解******* */
/*
  闭包定义：有权访问另外一个函数内部变量的函数。
*/
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
/* ******** */
/* ******** */
/* ******** */
/* ******** */
/* ******** */











