angular
    .module('app')
    .value('witnesses', [
        { name: 'Bob Weiss', position: 'Sr Dir-Software Engineering' },
        { name: 'David Williams', position: 'Sr Dr-Software Engineering' },
        { name: 'Bill Plendl', position: 'Dir-Software Engineering' },
        { name: 'Steven Moberg', position: 'Assc Dir Sr Application Architect' },
        { name: 'Brian Britten', position: 'Assc Dir Software Engineering Manager' }
    ])
    .value('assessment', {
        name: '[your name here]',
        role: 'Software Engineer',
        office: 'Omaha NE',
        skill: 'AngularJS',
        date: new Date()
    });