// src/Posts.js
import React, { Component } from 'react';

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false,
      errorMsg: ''
    };
  }

  // Method to fetch posts and update state
  loadPosts = () => {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => {
        if (!response.ok) {
          throw new Error(`HTTP error! Status: ${response.status}`);
        }
        return response.json();
      })
      .then(data => {
        this.setState({ posts: data });
      })
      .catch(error => {
        this.setState({ hasError: true, errorMsg: error.message });
      });
  };

  // Lifecycle hook - fetch posts when component mounts
  componentDidMount() {
    this.loadPosts();
  }

  // Error boundary method - catch errors in rendering/other lifecycle methods
  componentDidCatch(error, info) {
    this.setState({ hasError: true, errorMsg: error.toString() });
    alert(`An error occurred in Posts component: ${error.toString()}`);
    // Optionally log error and info to monitoring service here
    console.error('Error caught in Posts:', error, info);
  }

  // Render method to display posts or error message
  render() {
    if (this.state.hasError) {
      return (
        <div>
          <h3>Something went wrong loading posts.</h3>
          <p>{this.state.errorMsg}</p>
        </div>
      );
    }

    return (
      <div>
        <h2>Posts</h2>
        {this.state.posts.length === 0 ? (
          <p>Loading posts...</p>
        ) : (
          this.state.posts.map(post => (
            <div key={post.id} style={{ marginBottom: '20px' }}>
              <h3>{post.title}</h3>
              <p>{post.body}</p>
            </div>
          ))
        )}
      </div>
    );
  }
}

export default Posts;
