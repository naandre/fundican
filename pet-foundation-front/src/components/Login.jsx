import { Form, Input, Button } from "antd"
import axios from "axios";



export const Login = ({onLogin}) => {
    const API_URL =import.meta.env.VITE_API_URL;
    const handleLogin = async (values) => {
        values.username = values.username.trim();
        values.password = values.password.trim();
        try {
          const res = await axios.post(`${API_URL}/users`, {
            login: values.username,
            password: values.password,
          });
          const result = res.data;
          if (res.status === 200) {
            onLogin(result);
          } else {
            onLogin('');
            return;
          }
        } catch (err) {
          if (err?.response?.data === undefined) {
            onLogin('');
          } else {
            onLogin('');
          }
          onLogin('');
          return;
        }
      };
  return (
    <>
    <div
      style={{
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
        justifyContent: "center",
        minHeight: "100vh",
      }}
    >
    <div
        style={{
          width: "300px",
          padding: "20px",
          border: "1px solid #e0e0e0",
          borderRadius: "5px",
        }}
      >
        <Form
          name="loginForm"
          onFinish={handleLogin}
        >
          <Form.Item
            label="Username"
            name="username"
            rules={[
              { required: true, message: "Please input your username" },
            ]}
          >
            <Input />
          </Form.Item>

          <Form.Item
            label="Password"
            name="password"
            rules={[
              {
                required: true,
                message: "Please input your password",
              },
            ]}
          >
            <Input.Password />
          </Form.Item>

          <Form.Item>
            <Button type="primary" htmlType="submit" style={{ width: "100%" }}>
              Login
            </Button>
          </Form.Item>
        </Form>
      </div>
      </div>
    </>
  )
}
