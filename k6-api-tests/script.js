import http from "k6/http";
import { sleep } from "k6";

const API_URL = "https://localhost:7151/Index";
export const options = {
  stages: [
    { duration: "30s", target: 10 },
    { duration: "30s", target: 20 },
    { duration: "30s", target: 100 },
    { duration: "10s", target: 0 },
  ],
};

export default function () {
  http.get(API_URL);
  sleep(1);
}
