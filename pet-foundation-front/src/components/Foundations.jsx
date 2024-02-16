import { Table } from "antd"
import axios from "axios";
import { useCallback, useEffect, useState } from "react";
import { v4 as uuidv4 } from "uuid";


export const Foundations = ({auth}) => {
    const API_URL =import.meta.env.VITE_API_URL;
    const [data, setData] = useState([]);
    const columns = [
        {
          title: "ID Pet",
          dataIndex: "id",
          key: "id",
          // width: 50,
        },
        {
          title: "Pet Name",
          dataIndex: "petName",
          key: "petName"
        }
      ];

      const fetchData = useCallback(
        async () => {
          
          try {
            let URL_API = `${API_URL}/pets`;
            
            const response = await axios.get(URL_API,
              {
                headers: {
                  "Authorization": "Bearer "+ auth,
                }
              }
            );
            setData(response.data);
            
          } catch (error) {
            console.error("Error fetching data:", error);
            
          }
        }
      );
      useEffect(() => {
        // fetchDataClient();
        fetchData("", "", null);
      }, [fetchData]);
  return (
    <>
    <div
        className="site-layout-background h-auto"
        style={{
          padding: 10,
          display: "flex",
          flexDirection: "column",
          margin: 0,
          height: "auto",
          minHeight: "350px",
          overflow: "auto",
          backgroundColor: "#ffffff",
        }}
      >
        <Table
          rowKey={(r) => uuidv4()}
          columns={columns}
          dataSource={data}
          scroll={{ y: "max-content" }}
          size="small"
        />
      </div>
    </>
  )
}
