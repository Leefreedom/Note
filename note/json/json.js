/*
  JSON（JavaScript Object Natation）:
    - 用来存储和交换信息的语法。类似于XML。
    - JSON比XML更小、更快、更易解析。
    - 用来序列化对象、数组、数值、字符串、布尔值、null。
  基本格式：****不管是属性名还是属性值都必须带双引号****
    {
      "name":"xxx"
    }
  应用场景：Json是JavaScript语法来描述的数据对象，但是JSON仍然独立于语言和平台，解析器和库支持许多不同的编程语言（java、php...）
*/

/*
    JSON的使用：
      --JSON对象本身并没有其他作用，不能被调用或者作为构造函数。
      --唯一的作用是：将数据格式转换成json，因为json易解析，内存小。

    常用的方法：
      --json.stringify(); //将js对象||值转换成json字符串。
      --json.parse(); //将json字符串解析成js对象||值。
*/

/* 
    JSON.stringify()的九大特性
    一、对于undefined,任意函数,symbol三个特殊的值，分别作为对象的属性值、数组元素、单独的值时,
        json.stringify()将会返回什么?
    **解：
        当undefined,任意函数,symbol作为对象的属性值时,json.satringfy()将跳过对他们的序列化。
    **补充：
        若undefined,任意函数,symbol作为数组元素时,json.satringfy()会将这些序列化为null。
        若单独序列化这些值，返回undefined。
*/
const data1 = {
  a: "aaa",
  b: undefined,
  c: function () { },
  fn: Symbol("cc")
}
JSON.stringify(data1);//{"a":"aaa"}

/*
  二、正如我们第一特性描述的一样，json.satringfy()序列化时会忽略一些特殊的值。
      所以我们不能保证序列化后的字符串还是依照原来的顺序。
*/

const data2 = {
  a: "aaa",
  b: undefined,
  c: function () { },
  fn: Symbol("cc"),
  d: "dd"
}
JSON.stringify(data2);//{"a":"aaa","d":"dd"}

/* 
  三、在调用json.satringfy()时，存在toJSON()函数,该函数返回什么值，序列化结果就返回什么值，并且直接忽略其他属性的值。
*/
const data3 = {
  a: "aaa",
  toJSON: function () {
    return "我是json"
  }
}
JSON.stringify(data3);// "我是json"

/* 
  四、json.satringfy()将会正常序列化Date对象的值
  ****解：
    Date对象内置了toJSON(),因此Date对象会被当作字符串处理。
*/
JSON.stringify({ now: new Date() }); //"{"now":"2019-12-09T07:42:11.973Z"}"

/* 
  五、json.satringfy()对NAN、Infinity、null格式化的数值都返回null
*/
JSON.stringify(NaN);//null
JSON.stringify(Infinity);//null
JSON.stringify(null);//null

/* 
  六、基本类型的序列化，String、Number、Boolean,在序列化过程中自动转换为对应的原始值。
*/
JSON.stringify([new Number(1), new String("false", new Boolean(false))]);//"[1,"false",false]"

/* 
  七、其他类型对象,Map/Set/WeakMap/WeakSet,仅会序列化可枚举的属性
      不可枚举的属性,会自动被忽略。
*/
JSON.stringify(Object.create(null, {
  x: { value: "json", enumerable: false },
  y: { value: "stringify", enumerable: true }
}));//stringify

/* 
  八、实现深拷贝最简单粗暴的方法就是序列化：JSON.parse(JSON.stringify())

  ****补：序列化深拷贝报错缘由。
  ****解：这个方式实现深拷贝，会因为序列化的诸多特性从而导致诸多的坑点，比如循环引用的问题。
      包含循环引用的对象，通过序列化实现深拷贝，会抛出错误。
*/
const obj = {
  name: "loopObj"
}
const loopObj = {
  obj
}
obj.loopObj = loopObj
/* 上述为循环引用，两个对象内部，互相引用了对方。 */
function deepClone(obj) {
  return JSON.parse(JSON.stringify(obj))
}
deepClone(obj)


/* 
  九、所有以symbol为属性键的属性会被完全忽略掉,即便replacer参数中强制指定包含他们。
*/
JSON.stringify({ [Symbol.for("json")]: "stringify" }, function () {
  if (typeof k === 'symbol') {
    return v;
  }
}); //undefined

/*
  replacer是JSON.stringify()的第二个参数，比较少用。但是在某些方面可以很方便。
  在JSON.stringify()的第二个参数可以为函数，也可以为数组。

  函数：JSON.stringify({a:"xx"},(key,value)=>{
    //序列每一项时，都会调用该函数。类似于数组的filter()等回调函数。
  })

  数组：数组的值代表将被序列化成JSON字符串的属性名，也就是数组中包含值，就是序列化的值。
*/

const jsonObj = {
  name: "name",
  json: "json"
};
JSON.stringify(jsonObj, ["json"]);//"{"json":"json"}"































