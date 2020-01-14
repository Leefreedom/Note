/*
    在mpvue中使用iview weapp


    1、i-model、acrion-sheet两个iview的组件中函数的返回值无法获取问题？
        在iview weapp中组件通过click事件，即this.triggerEvent(‘click’, { index })来进行父子组件通信。但是mpvue无法从event.mp中读取到正确的detail。
        原因是因为mpvue将click事件编译为tap导致this.triggerEvent(‘click’, { index })无法找到click句柄。

        解决方案：
                修改原生组件中的绑定事件
                    this.triggerEvent('click', { index }) => this.triggerEvent('iclick', { index })

                对应的模版@click => @iclick

*/