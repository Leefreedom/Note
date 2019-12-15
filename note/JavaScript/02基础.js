/* ****函数的arguments为什么不是数组？如何转换为数组**** */

/* 
  因为arguments本身不能调用数组的相关方法，他是另一种对象类型。只不过属性从0开始，具备length，callee属性 
  统称这类为----类数组
  常见的类数组: 1.getElementsByTagName,getElementsByClassName获得的html集合
               2.querySeletion获得的nodeList集合

*/

/* ****将类数组转换成数组**** */
/* 这样就可以调用数组的很多方法 */

/* 第一种方法 Array.prototype.slice.call()*/
function sum1(a, b) {
  let args = Array.prototype.slice.call(arguments)
  console.log(args instanceof Array);//true
  console.log(args.reduce((sum, cur) => sum + cur));
}
sum1(1, 2);//3

/* 第二种方法 Array.from()*/
/* 这种方法也可以用来转换Set，Map */
function sum2(a, b) {
  let args = Array.from(arguments)
  console.log(args instanceof Array);//true
  console.log(args.reduce((sum, cur) => sum + cur));
};
sum2(1, 2);//3
/* 第三种方法 ES6展开运算符*/
function sum3(a, b) {
  let args = [...arguments]
  console.log(args instanceof Array);//true
  console.log(args.reduce((sum, cur) => sum + cur));
}
sum3(1, 2);//3

/* 第四种方法 Array.prototype.concat.apply()*/
function sum4(a, b) {
  let args = Array.prototype.concat.apply([], arguments);//apply会展开第二个参数arguments
  console.log(args instanceof Array);//true
  console.log(args.reduce((sum, cur) => sum + cur));
}
sum4(1, 2);//3

/* ****forEach中的return有效果吗?如何中断forEach循环**** */

/* 在forEach中的ruturn是不会返回的，函数仍会继续执行 */
let arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
/* return无效 */
arr.forEach((item) => {
  if (item === 5) {
    return;//无效
  }
  console.log(item);
})
// 中断方法
/* 使用try...catch,在需要中断的地方抛出错误  */
try {
  arr.forEach((item) => {
    if (item === 5) {
      throw Error
    }
    console.log(item);
  })
} catch (error) {
  console.log("此时item=5");
}
/* 官方推荐使用some()和every()替代forEach (every尝试不行)*/
arr.some((item) => {
  if (item === 5) {
    return true; //some方法在执行是，遇到return true时，中断
  }
  console.log(item);
})

/* arr.every((item) => {
  if (item === 5) {
    return false; //every方法在执行是，遇到return 时，中断
  }
  console.log(item);
}) */



/* ****js判断数组中是否包含某个值**** */

/* 第一种方法---array.indexOf() */
let arr2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
console.log(arr2.indexOf(5));//返回对应值的索引
console.log(arr2.indexOf(15));//不存在返回-1
/* 第二种方法---array.includes() */
console.log(arr2.includes(5));//true
console.log(arr2.includes(15));//false
/* 第三种方法---array.find() */
console.log(arr2.find((item) => item === 5));//返回数组中满足条件的第一个元素的值
/* 第四种方法---array.findeIndex() */
console.log(arr2.findIndex(item => item === 5));//返回数组中满足条件的第一个元素的索引


/* js中flat---数组扁平化 */
/* 开发过程中,会出现层叠数据结构的数组,为此需要将多层级转换成一级数组。 */
var ary = [1, [2, [3, [4, 5]]], 6];//=>[1,2,3,4,5,6]
var str = JSON.stringify(ary)
/* 使用ES6中的flat() */
console.log(ary.flat());
/* replace和split */
console.log(str.replace(/(\[|\])/g, "").split(","));
/* replace和JSON.parse */
console.log("[" + str.replace(/(\[|\])/g, "") + "]");
console.log(JSON.parse("[" + str.replace(/(\[|\])/g, "") + "]"));
/* 普通递归 */
let result = [];
let fn = function (ary) {
  for (let i = 0; i < ary.length; i++) {
    let item = ary[i]
    if (item instanceof Array) {//Array.isArray(item)
      fn(item)
    } else {
      result.push(item)
    }
  }
}
fn(ary)
console.log(result, "result");
/* reduce函数迭代 */
var ary1 = [1, [2, [3, [4, 5]]], 6];//=>[1,2,3,4,5,6]
function flatten(ary) {
  return ary.reduce((pre, cur) => {//pre累计器,cur当前值
    return pre
  })
}
console.log(flatten(ary1));

/* 扩展运算符 */
//只要有一个元素有数组，那就继续循环
while (ary1.some(Array.isArray)) {
  ary1 = [].concat(...ary)
}
console.log(ary1);

/* 数组中的高阶函数 */


