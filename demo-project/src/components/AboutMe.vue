<template>
  <div class="about">
      <ul>
          <li>姓名: {{name}}</li>
          <li>年龄: {{26}}</li>
          <li>性别: {{sex}}</li>
      </ul>
  </div>
</template>

<script>
import userAcount from '../model/userAcount'
export default {
  name: 'AboutMe',
  data(){
      return {
          name: 'jack',
          age: '26',
          sex: 'man'
      }
  }
}
</script>
