import axios from 'axios'
function UserAcount() {
    function getUser(){
        return axios.get('http://localhost:51239/api/useracount').then(res => {
            return res.data
        })
    }

    return {
        getUser,
    }
}

export default userAcount