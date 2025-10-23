package com.ebootis.spring_boot.services.processLager;

import com.ebootis.spring_boot.dtos.ProcessPositionDTO;
import com.ebootis.spring_boot.mappers.IMapper;
import com.ebootis.spring_boot.models.ProcessPosition;
import com.ebootis.spring_boot.services.generic.CombinedGenericServiceImpl;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Service;

@Service
public class ProcessServiceImpl extends CombinedGenericServiceImpl<ProcessPosition, ProcessPositionDTO,Integer> implements IProcessService {

    public ProcessServiceImpl(JpaRepository<ProcessPosition, Integer> repository, IMapper<ProcessPosition, ProcessPositionDTO> mapper) {
        super(repository, mapper);
    }
}
