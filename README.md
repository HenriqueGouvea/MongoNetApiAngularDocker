# .NET API with MongoDB, Docker and Angular UI

This repository containes and API reading and creating documents in MongoDB. It has an UI developed in Angular with two pages consuming these endpoints.
The API and MongoDB are containerized with Docker and they are orchestrated via Docker Compose.

## Documents

The single entity used is the `Product` entity that has the following properties:

* ID
* Name
* PictureUrl
* Price
* IsDeleted

## Endpoints

There are 3 endpoints:

* Get all products: get all products that are not deleted
* Get all products by name with pagination: get app products given a name or a part of a name.
* Create: creates a new product

## Roadmap

- [ ] Back-end
	- [x] Create the API
	- [x] Integrate with MongoDB
	- [x] Create the repository layer
	- [x] Create mapping between entity and reponse and request objects
	- [x] Add the endpoints
	- [x] Add the exception handling middleware
	- [ ] Use logs
	- [ ] Add unit tests
	- [ ] API monitoring (Application Insights or Kibana)
	- [ ] Caching

- [ ] Front-end
	- [x] Create the Angular app
	- [x] Create the product list screen
	- [x] Create the product creation screen
	- [x] Add GDPR compliance measures (cookie consent and privacy policy page)
	- [ ] Add the product filter by name and pagination
	- [ ] Add unit tests
	- [ ] Add E2E tests

## Technologies

* .NET Core 7
* MongoDB
* Docker
* Angular
* Typescript