# My Space API

- [My Space API](#my-space-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)

## Auth

## Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "Musa",
    "lastName": "Zulu",
    "email": "zuluchs@gmail.com",
    "password": "Musa1232!"
}
```

#### Register Response

```js
200 OK
```

#### Register Response

```json
{
    "id": "941B177E-5744-40EC-A74F-F9A30F6FAE03",
    "firstName": "Musa",
    "lastName": "Zulu",
    "email": "zuluchs@gmail.com",
    "password": "Musa1232!",
    "token": "eyJhb..z9dqcnXoY"
}
```

## Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "zuluchs@gmail.com",
    "password": "Musa1232!"
}
```