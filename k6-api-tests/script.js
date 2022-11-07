import http from 'k6/http';
import { sleep } from 'k6';

const API_URL = 'https://localhost:7151/Index';

export default function () {
  http.get(API_URL);
  sleep(1);
}
