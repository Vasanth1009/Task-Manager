// import { useLocation, useParams } from 'react-router-dom';
// import { useState, useEffect } from 'react';
const Project = () => {
    // const router = useLocation();
    // const { id } = useParams();
    // const projectURL = 'http://localhost:5000/api/project/' + id;
    // const sectionURL = 'http://localhost:5000/api/section/';
    // const taskURL = 'http://localhost:5000/api/item/';

    // const [project, setProject] = useState([]);
    // const [sections, setSections] = useState([]);
    // const [tasks, setTasks] = useState([]);

    // useEffect(() => {
    //     getProjects();
    //     getSections();
    //     getTasks();
    // }, [projectURL]);

    // const getProjects = () => {
    //     if (id !== undefined) {
    //         fetch(projectURL)
    //             .then((response) => response.json())
    //             .then((data) => setProject(data));
    //     }
    // };

    // const getSections = () => {
    //     if (id !== undefined) {
    //         fetch(sectionURL)
    //             .then((response) => response.json())
    //             .then((data) => setSections(data));
    //     }
    // };

    // const getTasks = () => {
    //     if (id !== undefined) {
    //         fetch(taskURL)
    //             .then((response) => response.json())
    //             .then((data) => setTasks(data));
    //     }
    // };

    // console.log(sections);
    // console.log(tasks);
    return (
        <div className="project">
            {/* <div>
                <h1 className="project_title">{project.name}</h1>
            </div>

            <div className="section_list">
                {sections.map((section) => {
                    return (
                        <div className="section_item" key={section.id}>
                            <div className="section_name">{section.name}</div>
                            {tasks.map((task) => {
                                return (
                                    <div key={task.id}>
                                        <div className="task">
                                            {task.content}
                                        </div>
                                    </div>
                                );
                            })}
                        </div>
                    );
                })}
            </div> */}
        </div>
    );
};

export default Project;
