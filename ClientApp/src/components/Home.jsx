import React, { Component } from 'react';

export class Home extends Component {
  displayName = Home.name

  render() {
    return (
      <div>
        <h2>GG</h2>
        <h3>
          Basic Idea:
        </h3>
        <p>
          A social Platform,
          That lets its users set goals for themselves in form of a post.
           Other users subscribe to goals by investing reputation points. If the 
           Goal setter achieves its goal, subscribed ( and set their bets on
            goal achieved ) users are rewarded with reputation. Also the User achieving the
             goal gets reputation depending on the amount of subscription to his post ( multiplied
              by bet leverage (1 + bet not achived / bet achieved)).

        </p><p>

          After successfully achieving your goal ( the way to achievement has to be documented
          ) a manual is generated out of your post. When users have similar goal they can use
           this manual as guideline or motivation to achieve their goals and you can get reputation 
           for this manuals if many users find them interesting or helpful.
        </p>

      </div>
    );
  }
}
