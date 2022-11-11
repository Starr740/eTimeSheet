import Vue from 'vue'
import Router from 'vue-router'
import Hello from '@/components/Hello'
import AddProject from '@/components/AddProject'
import ProjectTeams from '@/components/ProjectTeams'
import Task from '@/components/Task'
import TimeSheet from '@/components/TimeSheet'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Hello',
      component: Hello
    },
    {
      path: '/add-project',
      name: 'AddProject',
      component: AddProject,
    },
    {
      path: '/project-teams',
      name: 'ProjectTeams',
      component: ProjectTeams,
    },
    {
      path: '/task',
      name: 'Task',
      component: Task,
    },
    {
      path: '/timeSheet',
      name: 'TimeSheet',
      component: TimeSheet,
    }
  ]
})
