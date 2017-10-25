<template>
  <div class="about">
      <ul>
          <li v-for="user in userList" :key="user.userId">
              用户Id：{{user.userId}}
              用户姓名：{{user.userName}}
              用户密码：{{user.password}}
          </li>
    
      </ul>
  </div>
</template>

<script>
import UserAcount from '../model/userAcount'
export default {
  data(){
      let userIns = UserAcount()
      return {
          userIns,
           userList: []
      }
  },
  components: {},
  created(){
      console.log(userIns)
      this.userIns.getUser().then(data => {
          this.userList = data
      })
  },
  mounted () {
  },
  beforeDestroy () {
  },
}
</script>
