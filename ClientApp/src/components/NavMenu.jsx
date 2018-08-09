import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';

export class NavMenu extends Component {
  displayName = NavMenu.name

  render() {
    return (
      <Navbar inverse fixedTop fluid collapseOnSelect>
        <Navbar.Header>
          <Navbar.Brand>
            <Link to={'/'}>aspnetAndReact</Link>
          </Navbar.Brand>
          <Navbar.Toggle />
        </Navbar.Header>
        <Navbar.Collapse>
          <Nav>
            <LinkContainer to={'/'} exact>
              <NavItem>
                <Glyphicon glyph='home' /> Home
              </NavItem>
            </LinkContainer>
            {/* <LinkContainer to={'/counter'}>
              <NavItem>
                <Glyphicon glyph='education' /> Counter
              </NavItem>
            </LinkContainer>
            <LinkContainer to={'/fetchdata'}>
              <NavItem>
                <Glyphicon glyph='th-list' /> Fetch data
              </NavItem>
            </LinkContainer> */}
            <LinkContainer to={'/userdetail'}>
              <NavItem>
                <Glyphicon glyph='trash' /> UserDetail
              </NavItem>
            </LinkContainer>
            <LinkContainer to={'/hot'}>
              <NavItem>
                <Glyphicon glyph='fire' /> HOT
              </NavItem>
            </LinkContainer>
          </Nav>
        </Navbar.Collapse>
      </Navbar>
    );
  }
}
