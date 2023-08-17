[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/9BlYPUXr)
# Creating and consuming Web API

1. Create one of the following databases based on what is assigned to you by your instructor:
   - **Online Shopping - Nomazon**
      - Create a *Nomazon* database
      - Create a table named *products* with columns: product_id, name, description, image, price,stockInHand.
      - image must contain a URL to any image online.
    - **IMDB - movie database**
        - Create a database named *imdb*
        - Create a table named *movies* with columns: movie_id, name, description, poster_url, release_date, rating
        - poster_url must contain a URL to any image online that shows the movie poster.
2. In the repository application you cloned, scaffold the database you created above in the FinalExamAPI project.
   Resource: https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-scaffold-example.html
3. Create REST API controllers based on the scaffolded class and test it out
4. Test out the newly created REST API.
5. In the FinalExamFrontend project, create front-end forms/components to consume the API. You must call both the GET and POST methods. When the user tries to get a movie/product by their ID, you must display all the details from the table including the image of a product/movie. 

## Useful resources:
1. Week 13 Class recording on Blackboard.
2. [Week 13 Lab Manual](https://github.com/TheCodingGrew/Week-13---Lab-Manual)
