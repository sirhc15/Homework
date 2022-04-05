import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { students: [], loading: true, contacts: [], showContacts: false }
        this.handleStudentClick = this.handleStudentClick.bind(this);
    }

    componentDidMount() {
        this.populateStudentData();
    }

    handleStudentClick(studentId, e) {
        console.log(studentId);
        this.populateContactData(studentId);
        console.log(this.state.contacts);
    }

    static renderContacts(contacts) {
        return (
            <div>
                <h3>Student Contacts</h3>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Relationship</th>
                            <th>Email Address</th>
                            <th>Mobile</th>
                            <th>Address</th>
                            <th>City</th>
                            <th>State</th>
                            <th>Zip Code</th>
                        </tr>
                    </thead>
                    <tbody>
                        {contacts.map(contact =>
                            <tr key={contact.contactId}>
                                <td>{contact.firstName} {contact.lastName}</td>
                                <td>{contact.relationship}</td>
                                <td>{contact.emailAddress}</td>
                                <td>{contact.mobile}</td>
                                <td>{contact.address}</td>
                                <td>{contact.city}</td>
                                <td>{contact.state}</td>
                                <td>{contact.zipCode}</td>
                            </tr>
                        )}
                    </tbody>
                </table>
            </div>
        );
    }

    render() {
        let contactTable = this.state.showContacts
            ? Home.renderContacts(this.state.contacts)
            : <div></div>;
        return (
            <div>
                <h1>Students</h1>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Student Id</th>
                            <th>School Code</th>
                            <th>Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.students.map(student =>
                            <tr key={student.studentId} onClick={(e) => this.handleStudentClick(student.studentId, e)}>
                                <td>{student.studentId}</td>
                                <td>{student.schoolCode}</td>
                                <td>{student.firstName} {student.lastName}</td>
                            </tr>
                        )}
                    </tbody>
                </table>
                    {contactTable}
            </div>
        );
    }

    async populateStudentData() {
        const response = await fetch('Student/Students');
        const data = await response.json();
        this.setState({ students: data, loading: false, contacts: this.state.contacts, showContacts: this.state.showContacts});
    }
    
    async populateContactData(studentId) {
        const response = await fetch('Student/Contacts/' + studentId);
        const data = await response.json();
        this.setState({ students: this.state.students, loading: this.state.loading, contacts: data, showContacts: true})
    }
}
