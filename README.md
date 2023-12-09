# .NET API with MongoDB, Docker and Angular UI

This repository containes and API reading and creating documents in MongoDB. It has an UI developed in Angular.
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

- [ ] Front-end
	- [ ] Create the Angular app
	- [ ] Create the product list screen
	- [ ] Add the product filter by name and pagination
	- [ ] Create the product creation screen
	- [ ] Add GDPR compliance measures
	- [ ] Add unit tests
	- [ ] Add E2E tests

## Technologies

	* .NET Core 7
	* MongoDB
	* Docker
	* Angular
	* Typescript